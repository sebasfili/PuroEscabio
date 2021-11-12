
using PuroEscabio.App.Model;
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
            BindingContext = new ProductListModel();
              
        }

        private async void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmPurchase(), true);
        }
    }
}