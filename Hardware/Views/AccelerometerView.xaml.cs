using Hardware.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hardware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccelerometerView : ContentPage
    {
        private readonly AccelerometerViewModel AccelerometerViewModel;

        public AccelerometerView()
        {
            InitializeComponent();
            AccelerometerViewModel = new AccelerometerViewModel();
            BindingContext = AccelerometerViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AccelerometerViewModel.Start();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            AccelerometerViewModel.Stop();
        }
    }
}