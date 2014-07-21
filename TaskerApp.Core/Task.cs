using System;

namespace TaskerApp.Core
{
	public class Task
	{

		public string Title {
			get;
			set;
		}

		public string Description {
			get;
			set;
		}

		public bool Done {
			get;
			set;
		}

		public int id {
			get;
			set;
		}

		public Task (string title, string desc, int id)
		{
			this.Title = title;
			this.Description = desc;
			this.Done = false;
			this.id = id;
		}
	}
}

