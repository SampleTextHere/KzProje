using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using Navigation2.Views;
using Navigation2.Models;
using Navigation2.Services;

namespace Navigation2.ViewModels
{
    class GirisViewModel : BaseViewModel
    {

        public string Username { get; set; }
        public string RegisterUsername { get; set; }
        public string Password { get; set; }
        public string RegisterPassword { get; set; }

       public Command LoginCommand { get; }
       public Command RegisterCommand { get; }

        public GirisViewModel()
        {
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(Register);           
        }

        private async void Login()
        {
            Account LoginAccount = new Account(Username, Password);
            var AccountList = await DatabaseManager.GetAccount();
            foreach (Account account in AccountList)
            {
                if (account.Username == LoginAccount.Username && account.Password == LoginAccount.Password)
                {
                    SetCurrentAccount(LoginAccount);
                    AppShell denemeShell = new AppShell();
                    denemeShell.Login();
                    App.Current.MainPage = denemeShell;
                    await Shell.Current.GoToAsync($"///{nameof(Anasayfa)}");
                }
            }          
        }

        private async void Register()
        {
            Account RegisterAccount = new Account(RegisterUsername, RegisterPassword);
            await DatabaseManager.AddAccount(RegisterAccount);
        }
    }
}
