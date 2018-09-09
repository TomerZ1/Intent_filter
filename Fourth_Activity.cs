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
    [Activity(Label = "Fourth_Activity")]
    [IntentFilter(new[] { "a3" }, Categories = new[] { Intent.CategoryDefault })]
    public class Fourth_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_fourth);


            // Create your application here
        }
    }
}