using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CompSciFinal
{
	[Activity (Label = "CompSciFinal", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			string Path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			TextView editText = FindViewById<EditText> (Resource.Id.editText1);
			Button button = FindViewById<Button> (Resource.Id.myButton);

			//Button button2 = FindViewById<Button> (Resource.Id.myButton2);

			Button br1 = FindViewById<Button> (Resource.Id.button1);

			Button br2 = FindViewById<Button> (Resource.Id.button2);

			Button br3 = FindViewById<Button> (Resource.Id.button3);

			Button up = FindViewById<Button> (Resource.Id.upbutton);

			Button down = FindViewById<Button> (Resource.Id.downbutton);
			//string Path = Directory.GetCurrentDirectory ();



			//setting up open from midscreen

			//br1.Text = ;
			if (File.Exists(@"" + Path + "/notecards/recent.txt")){

				string[] lines = File.ReadAllLines (@"" + Path + "/notecards/recent.txt");
				//string last2 = string.Format ("{0}{1}{2}", lines [lines.Count - 2], "\n", lines [lines.Count - 1]);
				//string[] lines = File.ReadAllLines(myFile)
				// Get the last three lines
				int a = 3;
				int b = 2;
				int c = 1;
				string l1 = (lines[lines.Length - a]);		//default 3
				string l2 = (lines[lines.Length - b]);		//default 2
				string l3 = (lines[lines.Length - c]);		//default 1

				br1.Text = l1;
				br2.Text = l2;
				br3.Text = l3;
				int d = a + 1;
				int e = b + 1;
				int f = c + 1;
				//up.Click += ;
					

				//http://developer.android.com/reference/android/content/res/AssetManager.html
				//InputStream inputStream = this.getResources().openRawResource(R.raw.yourfile);

				goto ne;

			}else{
				System.IO.Directory.CreateDirectory (@"" + Path + "/notecards");
				System.IO.File.WriteAllText(@"" + Path + "/notecards/recent.txt", "");
				goto ne;
			}

			ne:


			up.Click += delegate {
				string text = Intent.GetStringExtra ("MyData") ?? "Data not available";
			};


			//var textv = FindViewById<EditText> (Resource.Id.editText3);

			//var textView = FindViewById<TextView> (Resource.Id.text);

		
			//Button button1 = FindViewById<Button> (Resource.Id.myButton2);

			button.Click += delegate {
				//button.Text = string.Format ("{0} clicks!", count++);
				//SetContentView(Resource.Layout.CreatonofD);
				var showSecond = FindViewById<Button> (Resource.Id.myButton);
				showSecond.Click += (sender, e) => {
					//string Path = Directory.GetCurrentDirectory();			//change


					StartActivity (typeof(opendeck));


				};
			};

		









		
		
		


			//};










			//};
		
	


		}

		void Up_Click (object sender, EventArgs e)
		{
			
		}
}		
}
					//JACK TODO SET UP LOAD DECK FOR UP AND DOWN BUTTON ON THE MAIN PAGE, AS
					//YOU PRESS UP ONE, IT CHANGES THE MENUS THERE! SET IT UP AFTER THAT IT LEADS TO THE NOTE
					//CARDS OPENING UP AND IN TOP RIGHT IT SAYS "EDIT" I ALSO NEED TO FINISH THE CUSTOM
					//NOTECARD METHOD



//				/res/raw