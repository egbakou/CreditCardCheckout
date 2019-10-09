using ShopTimeline.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopTimeline.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopView : ContentPage
    {
        private CreditCardViewModel viewModel;

        public ShopView()
        {
            InitializeComponent();
            BindingContext = viewModel = new CreditCardViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}