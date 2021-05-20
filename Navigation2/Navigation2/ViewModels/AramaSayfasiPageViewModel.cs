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
using System.Threading;

namespace Navigation2.ViewModels
{
    class AramaSayfasiPageViewModel : BaseViewModel
    {
        public string Keyword { get; set; }
        public Command SearchCommand { get; }

        public AramaSayfasiPageViewModel()
        {
            SearchCommand = new Command(SearchByName);
        }

        private async void SearchByName()
        {
            DataHolder.GetProductsByName(Keyword);
            await Shell.Current.GoToAsync($"///{nameof(Anasayfa)}/{nameof(AramaSonucu)}");
        }

    }
}
