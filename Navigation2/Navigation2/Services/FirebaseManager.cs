using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Navigation2.Models;
using System.Collections.ObjectModel;

//deneme
//using Plugin.CloudFirestore;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;

namespace Navigation2.Services
{
    public static class FirebaseManager
    {
       

        static FirebaseClient fb;
        static async Task Init()
        {
            if (fb != null)
                return;

            fb = new FirebaseClient("https://kzproje-d9ad7-default-rtdb.firebaseio.com/");

            if (await GetAccount() == null)
            {
                foreach (var item in AccountManager.Accounts)
                {
                    await fb
                    .Child("Accounts")
                    .PostAsync(item);
                }
            }
        }

        public static async Task AddAccount(Account account)
        {
            await Init();
            
            await fb
                .Child("Accounts")
                .PostAsync(account);
        }

        public static async Task<IEnumerable<Account>> GetAccount()
        {
            await Init();

            var accounts = await fb.Child("Accounts").OnceAsync<Account>();
            var accountl = accounts.Select(item => new Account
            {
                Id = item.Object.Id,
                Username = item.Object.Username,
                Password = item.Object.Password
            }).ToList();

            if (accountl.Count == 0)
                return null;
            return accountl;
        }



    }
}
