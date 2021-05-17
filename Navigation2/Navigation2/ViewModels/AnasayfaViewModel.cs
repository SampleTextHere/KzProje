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
    class AnasayfaViewModel : BaseViewModel
    {

        
        public AnasayfaViewModel()
        {
            Products = GetProducts();
        }

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
    }
   

}
