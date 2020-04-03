
using Hardware.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hardware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailView : ContentPage
    {
        public EmailView()
        {
            InitializeComponent();
            BindingContext = new EmailViewModel();
        }
    }
}