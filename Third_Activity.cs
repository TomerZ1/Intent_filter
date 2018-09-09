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

namespace App3
{
    [Activity(Label = "Third_Activity")]
    [IntentFilter(new[] { "a2" }, Categories = new[] { Intent.CategoryDefault })]
    public class Third_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_third);


            // Create your application here
        }
    }
}