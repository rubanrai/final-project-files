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

namespace PLAY_FISH
{
    [Activity(Label = "Contact")]
    public class Contact : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Contact);
            Button btnCall = FindViewById<Button>(Resource.Id.btnCallUs);
            Button btnEmail = FindViewById<Button>(Resource.Id.btnEmail);


            btnCall.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("tel:8146052682");
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            btnEmail.Click += delegate
            {
                var email = new Intent(Android.Content.Intent.ActionSend);
                email.PutExtra(Android.Content.Intent.ExtraEmail, new string[] {
            "moneyroyalboys@gmail.com"
        });
                
                email.PutExtra(Android.Content.Intent.ExtraSubject, "Message");
                email.PutExtra(Android.Content.Intent.ExtraText, "");
                email.SetType("message/rfc822");
                StartActivity(email);

            };


        }
    }
}