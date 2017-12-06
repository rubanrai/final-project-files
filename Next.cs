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
    [Activity(Label = "Next")]
    public class Next : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Next);









            List<Data> Listdata = new List<Data>();

            Data data = new Data()
            {
                id = 0,
                name = "Location1",
               
                imageName = Resource.Drawable.one
             

            };
            Listdata.Add(data);
            Data data2 = new Data()
            {
                id = 0,
                name = "Location2",

                imageName = Resource.Drawable.four,
           


            };
            Listdata.Add(data2);
            Data data3 = new Data()
            {
                id = 0,

                name = "Location3",

                imageName = Resource.Drawable.three
             

            };
            Listdata.Add(data3);



            ListView mylist = (ListView)FindViewById(Resource.Id.ContactsListView);
            //if(mylist==null)
            // {
            //     Toast.MakeText(this, "My list is having null", ToastLength.Long).Show();
            // }
            // else
            // {

            //     Toast.MakeText(this, "My list not null", ToastLength.Long).Show();

            // }

            var adopter = new CustomAdopter(this, Listdata);
            //mylist.ScrollTo();

            mylist.Adapter = adopter;







        }
    }
}