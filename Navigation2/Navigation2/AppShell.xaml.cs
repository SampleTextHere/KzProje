using Xamarin.Forms;
using Navigation2.ViewModels;
using Navigation2.Views;

namespace Navigation2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {

        public AppShell()
        {
            InitializeComponent();
            AccountPage.IsVisible = false;
            Routing.RegisterRoute(nameof(Sepet), typeof(Sepet));            
            Routing.RegisterRoute(nameof(AramaSayfasi), typeof(AramaSayfasi));            
            Routing.RegisterRoute(nameof(AramaSonucu), typeof(AramaSonucu));
            Routing.RegisterRoute(nameof(SatinAlindi), typeof(SatinAlindi));          
        }
        public void Login()
        {
            LoginPage.IsVisible = false;
            AccountPage.IsVisible = true;
        }
    }
}
