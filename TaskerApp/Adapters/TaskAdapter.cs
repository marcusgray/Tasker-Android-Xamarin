using System;
using System.Collections.Generic;
using TaskerApp.Core;
using Android.App;
using Android.Widget;
using Android.Views;

namespace TaskerApp.Android
{

	class TaskAdapter : BaseAdapter<TaskerApp.Core.Task>
	{
		Activity context = null;
		IList<Task> tasks = new List<TaskerApp.Core.Task>();

		public TaskAdapter (Activity context, IList<TaskerApp.Core.Task> tasks) : base ()
		{
			this.context = context;
			this.tasks = tasks;
		}

		public override TaskerApp.Core.Task this[int position]
		{
			get { return tasks[position]; }
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override int Count
		{
			get { return tasks.Count; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = tasks[position];			
			var view = (convertView ?? 
				context.LayoutInflater.Inflate(
					Resource.Layout.TaskItem, 
					parent, 
					false)) as LinearLayout;
					
			var txtName = view.FindViewById<TextView>(Resource.Id.Title);
			var txtDescription = view.FindViewById<TextView>(Resource.Id.Description);
			var txtDone = view.FindViewById<TextView>(Resource.Id.Done);

			txtName.SetText (item.Title, TextView.BufferType.Normal);
			txtDescription.SetText (item.Description, TextView.BufferType.Normal);
			txtDone.SetText (item.Done?"Done":"In progress", TextView.BufferType.Normal);

			return view;
		}

	}

}

