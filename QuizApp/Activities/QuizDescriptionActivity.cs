using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V7.App;

namespace QuizApp.Activities
{
    [Activity(Label = "QuizDescriptionActivity", Theme ="@style/AppTheme")]
    public class QuizDescriptionActivity : AppCompatActivity
    {
        private TextView _quizTopicTextView;
        private TextView _descriptionTextView;
        private ImageView _quizImageView;
        private Button _startQuizButton;

        private string _quizTopic;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.selected_topic);

            _quizTopicTextView = FindViewById<TextView>(Resource.Id.quizTopicText);
            _descriptionTextView = FindViewById<TextView>(Resource.Id.quizDescriptionText);
            _quizImageView = FindViewById<ImageView>(Resource.Id.quizImage);
            _startQuizButton = FindViewById<Button>(Resource.Id.startQuizButton);

            _quizTopic = Intent?.GetStringExtra("topic");
            _quizTopicTextView.Text = _quizTopic;
            _quizImageView.SetImageResource(GetImage(_quizTopic));
        }

        public int GetImage(string topic)
        {
            var imageInt = topic switch
            {
                "History" => Resource.Drawable.history,
                "Geography" => Resource.Drawable.geography,
                "Space" => Resource.Drawable.space,
                "Business" => Resource.Drawable.business,
                "Engineering" => Resource.Drawable.engineering,
                "Programming" => Resource.Drawable.programming,
                _ => 0
            };

            return imageInt;
        }
    }
}