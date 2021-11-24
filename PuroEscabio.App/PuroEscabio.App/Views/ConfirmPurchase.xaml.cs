using PuroEscabio.App.Model;
using PuroEscabio.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuroEscabio.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmPurchase : ContentPage
    {
        public IList<ProductViewModel> SelectedProducts;

        public ConfirmPurchase()
        {
            InitializeComponent();
        }

        public ConfirmPurchase(ProductListModel products)
        {
            InitializeComponent();
            SelectedProducts = products.Products.Where(x => x.Selected == true).ToList();
            BindingContext = SelectedProducts;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private async void confirm_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Puro Escabio", $"Compra Confirmada", "Aceptar");
            await Navigation.PushAsync(new ProductList(), true);
        }
    }
}