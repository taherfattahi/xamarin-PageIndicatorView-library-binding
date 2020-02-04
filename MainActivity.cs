using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

using xamarin_binding1.SRC.Fragments;
using Android.Support.V4.View;

namespace xamarin_binding1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        public static MainActivity Instance;

        Android.Support.V4.App.Fragment[] _fragments;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            //Forms.Init(this, savedInstanceState);
            Instance = this;

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            //_viewPager.PageSelected += ViewPager_PageSelected;

            _fragments = new Android.Support.V4.App.Fragment[] {
                Fragment0.NewInstance("Genres", "tab_genres"),
                Fragment1.NewInstance("Genres", "tab_genres"),
                //TheFragment.NewInstance("Titles", "tab_titles"),
                //TheFragment.NewInstance("Stream", "tab_stream"),
                //TheFragment.NewInstance("Showtimes", "tab_showtimes")
            };

            _viewPager.Adapter = new ViewPagerAdapter(SupportFragmentManager, _fragments);



        }


        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }


    public class ViewPagerAdapter : Android.Support.V4.App.FragmentPagerAdapter
    {
        Android.Support.V4.App.Fragment[] _fragments;

        public ViewPagerAdapter(Android.Support.V4.App.FragmentManager fm, Android.Support.V4.App.Fragment[] fragments) : base(fm)
        {
            _fragments = fragments;
        }

        public override int Count => _fragments.Length;

        public override Android.Support.V4.App.Fragment GetItem(int position) => _fragments[position];
    }

}