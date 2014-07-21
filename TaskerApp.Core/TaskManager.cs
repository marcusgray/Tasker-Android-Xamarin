using System;
using System.Collections.Generic;

namespace TaskerApp.Core
{
	public static class TaskManager
	{

		private static IList<Task> Tasks = new List<Task>();

		public static IList<Task> GetTasks()
		{
			return Tasks;
		}

		public static Task GetTask(int id)
		{
			return Tasks [id];
		}

		public static void AddTask()
		{
			Task task = new Task ("Title", "Description", Tasks.Count + 1);
			Tasks.Add (task);
		}

		public static void EditTask(int id, string title, string desc, bool done)
		{
			Tasks [id].Title = title;
			Tasks [id].Description = desc;
			Tasks [id].Done = done;
		}

		public static void RemoveTask(int id)
		{
			Tasks.RemoveAt (id);
		}

	}
}

