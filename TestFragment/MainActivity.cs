using Android.App;
using Android.Widget;
using Android.OS;

namespace TestFragment
{
    [Activity(Label = "TestFragment", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private Button _button;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _button = FindViewById<Button>(Resource.Id.testbutton);

            _button.Click += (sender, e) =>
            {
                var transaction = FragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.container, new TestFragment());
                transaction.Commit();
            };
        }
    }
}

