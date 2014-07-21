using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Mono.Data.Sqlite;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TaskerApp.Android
{
	public static class TaskDatabase
	{

		public static void InitializeDatabase()
		{
			var documents = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);

		}

	}
}

