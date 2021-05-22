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

using Plugin.CloudFirestore;

namespace Navigation2.Services
{
    public static class FirebaseManager
    {
       

        static FirebaseClient fb;
        static async Task Init()
        {
            if (fb != null)
                return;

            var document = await CrossCloudFirestore.Current
                                                    .Instance
                                                    .Collection(Account.CollectionPath)
                                                    .GetAsync();
            var account = document.ToObjects<Account>();

            if (account.Count() == 0 || account == null)
            {
                foreach (var item in AccountManager.Accounts)
                {
                    await CrossCloudFirestore.Current
                                     .Instance
                                     .Collection("accounts")
                                     .AddAsync(item);
                }
            }
        }

        public static async Task AddAccount(Account account)
        {
            await Init();
            
            var accounts = await GetAccount();
            foreach (Account item in accounts)
            {
                if (item.Username == account.Username && item.Password == account.Password)
                {
                    return;
                }
            }
            await CrossCloudFirestore.Current
                                     .Instance
                                     .Collection(Account.CollectionPath)
                                     .AddAsync(account);
        }

        public static async Task<IEnumerable<Account>> GetAccount()
        {
            await Init();

            var document = await CrossCloudFirestore.Current
                                                    .Instance
                                                    .Collection(Account.CollectionPath)
                                                    .GetAsync();
            var account = document.ToObjects<Account>();

            if (!account.Any())
                return null;
            return account;
        }



    }
}
