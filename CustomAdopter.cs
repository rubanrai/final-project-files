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
using Java.Lang;
using Android;
using Android.Views.Animations;


namespace PLAY_FISH
{
    public class viewHolder:Java.Lang.Object
    {
        public TextView Name { get; set; }
        public TextView dateTime { get; set; }
        public TextView subTitle { get; set; }
        public Button btnBuy { get; set; }
        public ImageView img { get; set; }

    }



    public class CustomAdopter : BaseAdapter
    {
        private Activity activity;
        private List<Data> data;

        public CustomAdopter(Activity activity, List<Data> data)
        {
            this.activity = activity;
            this.data = data;
        }
        public override int Count
        {
            get
            {
                return data.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return data[position].id;
        }
        private int lastPosition = -1;
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.Row, parent, false);
            TextView Name = view.FindViewById<TextView>(Resource.Id.txtName);
          
          
            ImageView img= view.FindViewById<ImageView>(Resource.Id.img);
         
            Name.Text = data[position].name;
           
            img.SetImageResource(data[position].imageName);
          





            Animation animation = AnimationUtils.LoadAnimation(activity, (position > lastPosition) ? Resource.Layout.up_from_bottom : Resource.Layout.down_from_top);
            view.StartAnimation(animation);
            lastPosition = position;


            return view;

        }
    }
}