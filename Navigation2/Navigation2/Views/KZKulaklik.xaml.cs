using Navigation2.Models;
using Navigation2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KZKulaklik : ContentPage
    {
        public KZKulaklik()
        {
            InitializeComponent();
            BindingContext = new KZKulaklikViewModel();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = ((CollectionView)sender).SelectedItem as Product;
            if (selectedProduct == null)
                return;

            await Navigation.PushAsync(new UrunDetay(selectedProduct));

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}