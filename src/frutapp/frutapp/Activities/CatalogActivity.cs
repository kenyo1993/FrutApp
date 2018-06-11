using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using frutapp.Model;

namespace frutapp.Activities
{
    [Activity(Label = "CatalogActivity")]
    public class CatalogActivity : Activity
    {
        ListView listViewCatalog;
        List<Product> productList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_catalog);


            // Create your application here
        }


    }
}