using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuroEscabio.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Puro Escabio", $"Ingresó como {EnUser.Text} - {EnPassword.Text}", "Aceptar");
            await Navigation.PushAsync(new ProductList(), true);
        }
    }
}