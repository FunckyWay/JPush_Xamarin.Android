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
using Android.Util;

namespace JPA
{
    [Activity(Label = "FirstPage")]
    public class FirstPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
          
            SetContentView(Resource.Layout.FirstPage);

            Button btn = FindViewById<Button>(Resource.Id.Btn);
            DisplayMetrics dm = new DisplayMetrics();
            WindowManager.DefaultDisplay.GetMetrics(dm);
            btn.Click += (s, arg) =>
            {
                
              
                
            };
           
            

            // Create your application here
        }

        
    }
}