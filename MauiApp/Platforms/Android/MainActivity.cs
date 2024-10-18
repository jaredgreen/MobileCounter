using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace MobileCounter;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[Register("com.uplift.mobilecounter.MainActivity")]
public class MainActivity : MauiAppCompatActivity
{
}