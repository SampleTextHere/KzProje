using Navigation2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Navigation2.Services;

namespace Navigation2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Giris : ContentPage
    {
        public Giris()
        {
            InitializeComponent();
            BindingContext = new GirisViewModel();
        }
        public void Login()
        {
            buton.IsVisible = false;
        }

        private void buton_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}