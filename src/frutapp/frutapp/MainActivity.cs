using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using frutapp.Activities;
using Android.Content;

namespace frutapp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btngo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            btngo = FindViewById<Button>(Resource.Id.button1);
            btngo.Click += changeOfIntent;
            // Set our view from the "main" layout resource
            
        }

        private void changeOfIntent(object sender, EventArgs e)
        {
            Intent newActivity = new Intent(this, typeof(CatalogActivity));
            this.StartActivity(newActivity);
        }

        

    
    }
}

