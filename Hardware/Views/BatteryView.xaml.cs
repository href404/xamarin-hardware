using Hardware.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hardware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatteryView : ContentPage
    {
        public BatteryView()
        {
            InitializeComponent();
            BindingContext = new BatteryViewModel();
        }
    }
}