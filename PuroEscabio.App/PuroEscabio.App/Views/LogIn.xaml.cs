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
            if (!string.IsNullOrWhiteSpace(EnUser.Text) && !string.IsNullOrWhiteSpace(EnPassword.Text))
            {
                await Navigation.PushAsync(new ProductList(), true);
            }
            else
            {
                await DisplayAlert("Puro Escabio", $"Debe ingresar el Usuario y Contraseña", "Aceptar");

            }

        }
    }
}