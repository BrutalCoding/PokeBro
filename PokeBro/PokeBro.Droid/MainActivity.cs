using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;

namespace PokeBro.Droid
{
    [Activity(Label = "PokeBro", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity//global::Xamarin.Forms.Platform.Android.FormsApplicationActivity //global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            // set the layout resources first
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

            // then call base.OnCreate and the Xamarin.Forms methods
            base.OnCreate(bundle);
            //SetContentView(Resource.Layout.activity_main);
            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

