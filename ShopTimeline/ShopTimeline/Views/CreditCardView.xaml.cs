using ShopTimeline.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopTimeline.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditCardView : ContentPage
    {
        private CreditCardViewModel viewModel;

        public CreditCardView()
        {
            InitializeComponent();
            BindingContext = viewModel = new CreditCardViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}