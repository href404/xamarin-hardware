using Android.App;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
[assembly: UsesPermission(Android.Manifest.Permission.BatteryStats)]
[assembly: UsesPermission(Android.Manifest.Permission.Vibrate)]