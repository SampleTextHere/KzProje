using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Navigation2.ViewModels;
using Navigation2.Views;
using Navigation2.Models;
using System.Threading.Tasks;


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
            
            Account account = new Account(Username, Password);
            if (CheckLogin(account))
            {
                SetCurrentAccount(account);
                AppShell denemeShell = new AppShell();
                denemeShell.Login();
                App.Current.MainPage = denemeShell;
                await Shell.Current.GoToAsync($"///{nameof(Anasayfa)}");
            }
            else
            {
                //login başarısız
            }

        }

        private void Regiser()
        {
            Account account = new Account(RegisterUsername, RegisterPassword);
            RegisterAccount(account);
        }

        private void Register()
        {
            var account = new Account(RegisterUsername, RegisterPassword);
            if (!CheckLogin(account))
            {
                RegisterAccount(account);
            }
        }
    }
}
