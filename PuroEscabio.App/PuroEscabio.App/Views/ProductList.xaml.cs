
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuroEscabio.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductList : ContentPage
    {
        public ProductList()
        {
            InitializeComponent();
            BindingContext =
               new[]
               {
                   new
                   {
                       FirstName = "Juan",
                       Phone = "(123)45678",
                       Email = "amigo1@hotmail.com",
                   },
                   new
                   {
                       FirstName = "Pedro",
                       Phone = "(123)45678",
                       Email = "amigo1@hotmail.com",
                   },
                   new
                   {
                       FirstName = "Luis",
                       Phone = "(123)45678",
                       Email = "amigo1@hotmail.com",
                   },
               }.ToList();
        }


    }
}