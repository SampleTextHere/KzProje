using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Navigation2.ViewModels;
using Navigation2.Views;
using Navigation2.Models;
using Navigation2.Services;

namespace Navigation2.ViewModels
{
    class KZKulaklikViewModel : BaseViewModel
    {
        public KZKulaklikViewModel()
        {
            DataHolder.GetProductsByCategory("kulaklık");
            Products = DataHolder.FilteredList;
        }
    }
}

