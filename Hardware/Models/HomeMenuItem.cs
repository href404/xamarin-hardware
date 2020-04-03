namespace Hardware.Models
{
    public class HomeMenuItem : NotifyModel
    {
        private MenuItemType id;
        private string title;

        public MenuItemType Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }

    public enum MenuItemType
    {
        Application,
        Battery,
        Vibration,
        Email
    }
}
