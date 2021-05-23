using Navigation2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Navigation2.ViewModels
{
    public class UrunDetayViewModel : BaseViewModel
    {
        
        public UrunDetayViewModel(Product selectedProduct)
        {
            SelectedProduct = selectedProduct;

        }


    }
}
