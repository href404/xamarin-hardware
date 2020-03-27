using Hardware.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hardware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VibrationView : ContentPage
    {
        public VibrationView()
        {
            InitializeComponent();
            BindingContext = new VibrationViewModel();
        }
    }
}