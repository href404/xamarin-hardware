using Hardware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Hardware.Views
{
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        private const int FIRST_MENU_ITEM = 0;

        public MenuPage()
        {
            InitializeComponent();

            List<HomeMenuItem> menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem { Id = MenuItemType.Application, Title=Enum.GetName(typeof(MenuItemType), MenuItemType.Application) },
                new HomeMenuItem { Id = MenuItemType.Battery, Title=Enum.GetName(typeof(MenuItemType), MenuItemType.Battery) },
                new HomeMenuItem { Id = MenuItemType.Vibration, Title=Enum.GetName(typeof(MenuItemType), MenuItemType.Vibration) },
                new HomeMenuItem { Id = MenuItemType.Email, Title=Enum.GetName(typeof(MenuItemType), MenuItemType.Email) },
                new HomeMenuItem { Id = MenuItemType.Accelerometer, Title=Enum.GetName(typeof(MenuItemType), MenuItemType.Accelerometer) },
                new HomeMenuItem { Id = MenuItemType.Geolocation, Title=Enum.GetName(typeof(MenuItemType), MenuItemType.Geolocation) }
            };
            ListViewMenu.ItemsSource = menuItems;
            ListViewMenu.SelectedItem = menuItems[FIRST_MENU_ITEM];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                int id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await (Application.Current.MainPage as MainPage).NavigateFromMenu(id);
            };
        }
    }
}