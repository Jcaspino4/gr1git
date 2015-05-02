
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

namespace CompSciFinal
{
	[Activity (Label = "LoadDeck")]			
	public class LoadDeck : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			string Path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			SetContentView (Resource.Layout.Loaddeck);
			// Create your application here
			//Button newcard = FindViewById<Button> (Resource.Id.button2);
			//ExpandableListView eview1 = FindViewById<ExpandableListView> (Resource.Id.expandableListView1);
		}
	}
}

