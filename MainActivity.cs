using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading;

namespace PLAY_FISH
{
    [Activity(Label = "PLAY FISH", MainLauncher = true, Icon = "@drawable/icon",  Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class MainActivity : Activity
    {
     
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);





            // Get our button from the layout resource,
              Thread myThread = new System.Threading.Thread(new
            System.Threading.ThreadStart(SleepandStart));

              myThread.Start();
            //Thread.Sleep(4000);

            //Intent intent = new Intent(this, typeof(FirstScreen));
            //this.Finish();
            //StartActivity(intent);


        }
        protected void SleepandStart()
        {
            try { 
            Thread.Sleep(4000);
            Intent intent = new Intent(this, typeof(FirstScreen));
            this.Finish();
            StartActivity(intent);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "" + ex, ToastLength.Long).Show();
            }

        }
    }
}

