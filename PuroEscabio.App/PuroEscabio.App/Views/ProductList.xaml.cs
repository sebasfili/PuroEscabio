
using PuroEscabio.App.Model;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuroEscabio.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductList : ContentPage
    {
        private ProductListModel products;
        public ProductList()
        {
            InitializeComponent();
            products = new ProductListModel();
            BindingContext = products;

              
        }

        private async void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmPurchase(products), true);
        }

       
    }
}