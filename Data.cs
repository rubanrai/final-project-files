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
    public class Data
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dateTime { get; set; }
        public string subTitle { get; set; }
        public int imageName { get; set; }
        public string price { get; set; }
    }
}