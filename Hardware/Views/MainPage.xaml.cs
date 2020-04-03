using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

using Hardware.Models;

namespace Hardware.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {

        private Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            MenuPages.Add((int)MenuItemType.Application, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Application:
                        MenuPages.Add(id, new NavigationPage(new AppInfoView()));
                        break;
                    case (int)MenuItemType.Battery:
                        MenuPages.Add(id, new NavigationPage(new BatteryView()));
                        break;
                    case (int)MenuItemType.Vibration:
                        MenuPages.Add(id, new NavigationPage(new VibratorView()));
                        break;
                    case (int)MenuItemType.Email:
                        MenuPages.Add(id, new NavigationPage(new EmailView()));
                        break;
                    case (int)MenuItemType.Accelerometer:
                        MenuPages.Add(id, new NavigationPage(new AccelerometerView()));
                        break;
                }
            }

            NavigationPage newPage = MenuPages[id];
            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}