using Hardware.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hardware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeolocationView : ContentPage
    {
        private readonly GeolocationViewModel GeolocationViewModel;

        public GeolocationView()
        {
            InitializeComponent();
            GeolocationViewModel = new GeolocationViewModel();
            BindingContext = GeolocationViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GeolocationViewModel.Start();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            GeolocationViewModel.Stop();
        }
    }
}