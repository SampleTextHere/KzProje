using Navigation2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Navigation2.Services;

namespace Navigation2.ViewModels
{
    class KablolarViewModel : BaseViewModel
    {
        public KablolarViewModel()
        {
            DataHolder.GetProductsByCategory("kablo");
            Products = DataHolder.FilteredList;
        }
    }
}
