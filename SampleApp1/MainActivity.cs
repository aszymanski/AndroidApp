using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Webkit;
using System;

namespace SampleApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public void GoToActivity(Type myActivity)
        {
            StartActivity(myActivity);
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.button1);


            button.Click += delegate
            {
                //button.SetBackgroundColor(Android.Graphics.Color.Blue);
                //SetContentView(Resource.Layout.test);
                GoToActivity(typeof(SampleActivity));
            };


        }
    }
}