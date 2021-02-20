using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using QuizApp.Activities;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace QuizApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        private Toolbar _toolbar;

        private LinearLayout _historyLayout;
        private LinearLayout _spaceLayout;
        private LinearLayout _geographyLayout;
        private LinearLayout _engineeringLayout;
        private LinearLayout _programmingLayout;
        private LinearLayout _businessLayout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            //Setup toolbar
            SetSupportActionBar(_toolbar);
            SupportActionBar.Title = "Topics";
            var actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            //Views Setups
            _historyLayout = FindViewById<LinearLayout>(Resource.Id.historyLayout);
            _spaceLayout = FindViewById<LinearLayout>(Resource.Id.spaceLayout);
            _engineeringLayout = FindViewById<LinearLayout>(Resource.Id.engineeringLayout);
            _programmingLayout = FindViewById<LinearLayout>(Resource.Id.programmingLayout);
            _businessLayout = FindViewById<LinearLayout>(Resource.Id.businessLayout);
            _geographyLayout = FindViewById<LinearLayout>(Resource.Id.geographyLayout);

            //Click event handler

            _historyLayout.Click += HistoryLayoutOnClick;
            _spaceLayout.Click += SpaceLayoutOnClick;
            _geographyLayout.Click += GeographyLayoutOnClick;
            _engineeringLayout.Click += EngineeringLayoutOnClick;
            _programmingLayout.Click += ProgrammingLayoutOnClick;
            _businessLayout.Click += BusinessLayoutOnClick;
        }

        private void BusinessLayoutOnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        private void ProgrammingLayoutOnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Programming");
            StartActivity(intent);
        }

        private void EngineeringLayoutOnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Engineering");
            StartActivity(intent);
        }

        private void GeographyLayoutOnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }

        private void SpaceLayoutOnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }

        private void HistoryLayoutOnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent);
        }
    }
}