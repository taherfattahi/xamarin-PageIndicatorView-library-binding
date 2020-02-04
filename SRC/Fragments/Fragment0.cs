using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace xamarin_binding1.SRC.Fragments
{
    public class Fragment0 : Android.Support.V4.App.Fragment
    {

        string _title;
        string _icon;

        public static Fragment0 NewInstance(string title, string icon)
        {
            var fragment = new Fragment0();
            fragment.Arguments = new Bundle();
            fragment.Arguments.PutString("title", title);
            fragment.Arguments.PutString("icon", icon);
            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(Resource.Layout.fragment_layout0, container, false);

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}