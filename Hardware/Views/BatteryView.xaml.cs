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
            BindingContextChanged += OnBindingContextChanged;
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}