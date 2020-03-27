namespace Hardware.Models
{
    public enum MenuItemType
    {
        Application,
        Battery
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
