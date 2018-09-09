using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using Android.Content;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, Android.Views.View.IOnClickListener
    {

        EditText et1;
        Button btn1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            et1 = FindViewById<EditText>(Resource.Id.et1);
            btn1 = FindViewById<Button>(Resource.Id.btn1);

            btn1.SetOnClickListener(this);

        }

        public void OnClick(View v)
        {
            if (v==btn1)
            {
                if (et1.Text.ToString()=="a1")
                {
                    Intent intent = new Intent("a1");
                    StartActivity(intent);
                }
                else if (et1.Text.ToString() == "a2")
                {
                    Intent intent = new Intent("a2");
                    StartActivity(intent);
                }
                else if (et1.Text.ToString() == "a3")
                {
                    Intent intent = new Intent("a3");
                    StartActivity(intent);
                }
            }
        }
    }
}