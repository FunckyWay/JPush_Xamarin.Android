using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CN.Jiguang.Api;
using CN.Jpush.Android.Api;

namespace JPA
{
    [Activity(Label = "JPA", MainLauncher = true,Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Console.WriteLine("OnCreate Call~~~~~~");
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            JPushInterface.SetDebugMode(true);
            JPushInterface.Init(this);
            // Get our button from the layout resource,
            // and attach an event to it
         

          

          
            
        }

        protected override void OnStart()
        {
            base.OnStart();
            Console.WriteLine("OnStart Called");
        }

        protected override void OnResume()
        {
            base.OnResume();
            Console.WriteLine("OnResume Called~~~~~");
        }

        protected override void OnPause()
        {
            base.OnPause();
            Console.WriteLine("OnPause Called");
        }

        protected override void OnStop()
        {
            base.OnStop();
            Console.WriteLine("OnStop Called");
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            Console.WriteLine("OnRestart Called");
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Console.WriteLine("OnDestory");
        }

        
    }
}

