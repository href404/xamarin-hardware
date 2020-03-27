using Hardware.Models;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Hardware.Views
{
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            List<HomeMenuItem> menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Application, Title="Application" },
                new HomeMenuItem {Id = MenuItemType.Battery, Title="Battery" }
            };
            ListViewMenu.ItemsSource = menuItems;
            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await (Application.Current.MainPage as MainPage).NavigateFromMenu(id);
            };
        }
    }
}