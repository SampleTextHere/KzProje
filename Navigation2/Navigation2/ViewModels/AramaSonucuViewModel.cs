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
    class AramaSonucuViewModel : BaseViewModel
    {
        public AramaSonucuViewModel()
        {
            Products = DataHolder.FilteredList;
        }
    }
}
