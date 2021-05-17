using Navigation2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Navigation2.Services
{
    public static class AccountManager
    {
        public static ObservableCollection<Account> Accounts { get; set; }
        public static Account CurrentAccount { get; set; }

        public static void AddAccount(Account account)
        {
            foreach (Account item in Accounts)
            {
                if (account == item)
                {
                    return;
                }
            }
            Accounts.Add(account);
        }

        public static bool CheckLoginInfo(Account accountToCheck)
        {
            string username = accountToCheck.Username;
            string password = accountToCheck.Password;
            foreach (Account account in Accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static Account GetCurrentAccount()
        {
            return CurrentAccount;
        }

        static AccountManager()
        {
            Accounts = new ObservableCollection<Account>();
            Accounts.Add(new Account 
            { 
                Username = "Admin",
                Password = "Password"
            });
        }
    }
}
