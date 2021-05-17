using Navigation2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Navigation2.ViewModels
{
    class KablolarViewModel : BaseViewModel
    {
        public KablolarViewModel()
        {
            Products = GetProductsByCategory("kablo");
        }
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
    }
}
