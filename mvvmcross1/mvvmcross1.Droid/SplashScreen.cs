using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace mvvmcross1.Droid
{
    [Activity(
        Label = "mvvmcross1"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
