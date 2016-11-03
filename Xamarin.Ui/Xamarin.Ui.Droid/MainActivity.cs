using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace Xamarin.Ui.Droid
{
    [Activity(Label = "Xamarin.Ui", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            var start = DateTime.Now;
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            App.Logger += Logger;
            Logger($"Startup time: {(DateTime.Now - start).TotalMilliseconds}");
        }

        private void Logger(string s)
        {
            Log.Error("Xamarin.Ui", s);
            Toast.MakeText(this, s, ToastLength.Short).Show();
        }
    }
}

