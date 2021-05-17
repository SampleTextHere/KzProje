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
    public partial class Sepet : ContentPage
    {
        public Sepet()
        {
            InitializeComponent();
            BindingContext = new SepetViewModel();
        }
    }
}