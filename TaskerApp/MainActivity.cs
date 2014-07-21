using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TaskerApp.Core;
using TaskerApp.Android;

namespace TaskerApp.Android
{
	[Activity (Label = "Tasker", MainLauncher = true)]
	public class MainActivity : Activity
	{

		TaskAdapter Adapter;
		ListView listView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			Adapter = new TaskAdapter (this, TaskManager.GetTasks ());
			listView = FindViewById<ListView> (Resource.Id.TaskList);

			Button btn = FindViewById<Button> (Resource.Id.NewTask);
			btn.Click += delegate {
				TaskManager.AddTask();
				Adapter.NotifyDataSetChanged();
			};

			listView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				Intent intent = new Intent (this, typeof(EditTask));
				intent.PutExtra ("id", e.Position);
				StartActivity(intent);
			};

		}

		protected override void OnResume()
		{
			base.OnResume ();
			listView.Adapter = Adapter;
		}

	}
}


