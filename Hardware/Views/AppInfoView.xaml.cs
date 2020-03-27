using Hardware.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hardware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppInfoView : ContentPage
    {
        public AppInfoView()
        {
            InitializeComponent();
            BindingContext = new AppInfoViewModel();
        }
    }
}