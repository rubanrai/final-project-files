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
using System.Json;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;


namespace PLAY_FISH
{
    [Activity(Label = "FirstScreen" , Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class FirstScreen : Activity
    {
     
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FirstScreen);
            Button btnMenu = FindViewById<Button>(Resource.Id.button2);
            PopupMenu menu = new PopupMenu(this, btnMenu);
            menu.Inflate(Resource.Menu.menu);
            btnMenu.Click += delegate
            {
                
                
                menu.Show();

            };
            menu.MenuItemClick += (s1, arg1) => 
                {
                  switch (arg1.Item.TitleFormatted.ToString())
                    {
                        case "list of location visited by blogger":
                            StartActivity(new Intent(this, typeof(Location)));
                            
                            break;
                        case "Next vacation destination":
                            StartActivity(new Intent(this, typeof(Next)));
                            break;
                        case "Contact Blogger":
                            StartActivity(new Intent(this, typeof(Contact)));
                            break;

                    }
               
            };


       



    }
      





    }
}