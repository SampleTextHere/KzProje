using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Navigation2.Models;

namespace Navigation2.Services
{
    public static class DatabaseManager
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");
            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Account>();
        }

        public static async Task AddAccount(Account accountToInsert)
        {
            await Init();

            var accounts = await db.Table<Account>().ToListAsync();
            foreach (Account account in accounts)
            {
                if (account.Username == accountToInsert.Username && account.Password == accountToInsert.Password)
                {
                    return;
                }
            }
            await db.InsertAsync(accountToInsert);
        }

        public static async Task<IEnumerable<Account>> GetAccount()
        {
            await Init();
            
            var accounts = await db.Table<Account>().ToListAsync();
            if (accounts.Count == 0)
                return null;
            return accounts;
        }

    }
}
