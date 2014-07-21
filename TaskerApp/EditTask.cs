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
using TaskerApp.Core;

namespace TaskerApp.Android
{
	[Activity (Label = "EditTask")]			
	public class EditTask : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.EditScreen);

			int id = Intent.GetIntExtra ("id", 1);

			EditText title = FindViewById<EditText>(Resource.Id.TitleText);
			EditText description = FindViewById<EditText>(Resource.Id.DescriptionText);
			CheckBox completed = FindViewById<CheckBox>(Resource.Id.CompletedCheckBox);
			Button save = FindViewById<Button>(Resource.Id.SaveButton);
			Button delete = FindViewById<Button>(Resource.Id.DeleteButton);
			Button cancel = FindViewById<Button>(Resource.Id.CancelButton);

			Task task = TaskManager.GetTask (id);
			title.Text = task.Title;
			description.Text = task.Description;
			completed.Checked = task.Done;

			save.Click += delegate {
				task.Title = title.Text;
				task.Description = description.Text;
				task.Done = completed.Checked;
				Finish();
			};
			delete.Click += delegate {
				TaskManager.RemoveTask(id);
				Finish();
			};
			cancel.Click += delegate {
				Finish();
			};

		}
	}
}

