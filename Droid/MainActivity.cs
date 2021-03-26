using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Acr.UserDialogs;
using ImageCircle.Forms.Plugin.Droid;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Utility.Droid
{
    [Activity(Label = "Utility", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //AppCenter.Start("android=d0dddecd-9d56-463e-8dcb-b4abdeba4e27;" +
            //      "uwp={Your UWP App secret here};" +
            //      "ios={Your iOS App secret here}",
            //      typeof(Analytics), typeof(Crashes));
            AppCenter.Start("android=d0dddecd-9d56-463e-8dcb-b4abdeba4e27;" +
                  typeof(Analytics), typeof(Crashes));

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());

            UserDialogs.Init(this);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            ImageCircleRenderer.Init();

            FormsPlugin.Iconize.Droid.IconControls.Init(ToolbarResource, TabLayoutResource);

            LoadApplication(new App());
        }
    }
}
