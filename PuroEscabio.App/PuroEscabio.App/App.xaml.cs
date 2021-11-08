using PuroEscabio.App.Views;
using Xamarin.Forms;

namespace PuroEscabio.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LogIn())
            {
                BarBackgroundColor = Color.FromHex("#f39c12"),
                BarTextColor = Color.Accent
            };

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
