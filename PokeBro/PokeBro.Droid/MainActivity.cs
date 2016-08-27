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
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity //global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //base.OnCreate(bundle);

            //global::Xamarin.Forms.Forms.Init(this, bundle);
            //LoadApplication(new App());
            //Hieronder staat de nieuwe indeling

            // set the layout resources first
            
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

            // then call base.OnCreate and the Xamarin.Forms methods
            base.OnCreate(bundle);
            //SetContentView(Resource.Layout.main);
            //var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //Toolbar will now take on default actionbar characteristics
            //SetSupportActionBar(toolbar);
            //SupportActionBar.Title = "PokeBro - All In One Guide";

            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

