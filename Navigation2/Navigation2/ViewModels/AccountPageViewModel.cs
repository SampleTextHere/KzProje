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
    class AccountPageViewModel : BaseViewModel
    {
        public Command LogoutCommand { get; }
        public string Username { get; set; }

        public AccountPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            if (CurrentAccount() != null)
            {
                Username = CurrentAccount().Username;
            }            
        }

        private async void Logout()
        {
            App.Current.MainPage = new AppShell();
            await Shell.Current.GoToAsync($"///{nameof(Anasayfa)}");
        }
    }
}
