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
        Button btnAuth;
        EditText ediTextUsername;
        EditText ediTextPassword;
        EditText editTextToken;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAuth = FindViewById<Button>(Resource.Id.button1);
            ediTextUsername = FindViewById<EditText>(Resource.Id.editText1);
            ediTextPassword = FindViewById<EditText>(Resource.Id.editText2);
            editTextToken = FindViewById<EditText>(Resource.Id.editText3);

            btnAuth.Click += DoAuthentication;
        }
        private void DoAuthentication(object sender, EventArgs e)
        {
            if (ediTextUsername.Text.Equals("bichito") && ediTextPassword.Text.Equals("123456") && editTextToken.Text.Equals("EA1022"))
            {
                Toast.MakeText(this, "Usuario Válido", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Usuario Inválido, este teléfono se autodestruirá", ToastLength.Short).Show();
            }
        }
    }
}

