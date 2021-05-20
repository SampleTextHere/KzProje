using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Navigation2.Services;
using Navigation2.Models;

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

        private void SearchByName()
        {
            DataHolder.GetProductsByName("PRO");
            Products = DataHolder.FilteredList;
        }

    }
}
