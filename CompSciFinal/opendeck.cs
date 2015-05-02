
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
using System.IO;

namespace CompSciFinal
{
	[Activity (Label = "opendeck")]			
	public class opendeck : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.NewDeck);
			EditText editText = FindViewById<EditText> (Resource.Id.editText1);
			EditText editText2 = FindViewById<EditText> (Resource.Id.editText2);
			EditText editText3 = FindViewById<EditText> (Resource.Id.editText3);
		


			//Button newCard = FindViewById<Button> ()
			// Create your application here
			string i = editText.Text;
			string dn = editText2.Text;
			string g = editText3.Text;

			string Path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			//string Path = Directory.GetCurrentDirectory ();
			//string oi = Context.getFilesDir ();


			top:

			Button autodef = FindViewById<Button> (Resource.Id.button3);

			Button newcard = FindViewById<Button> (Resource.Id.button2);

			newcard.Click += delegate {
				if (File.Exists (@"" + Path + "/notecards")) {
					goto nen1; 
				} else {
					System.IO.Directory.CreateDirectory (@"" + Path + "/notecards");
					goto nen1;
				}
				nen1:
				if (File.Exists (@"" + Path + "/notecard/" + dn + ".txt")) {
					editText2.Text = "ERROR, ALREADY CREATED!";
					//goto nen1;
				} else {
					System.IO.File.WriteAllText (@"" + Path + "/notecard/" + dn + ".txt", dn);
					//nen1:		PAY ATTENTION HERE
					//goto nen1;


					System.IO.File.AppendAllText (@"" + Path + "/notecard/" + "/" + dn + ".txt", i + "\n" + g + "\n");	 //wri
					//goto top;






				}
			};





			autodef.Click += delegate {
				
				//string Path = GetDir();
				if (File.Exists (@"" + Path + "/notecards")) {
					goto nen; 
				} else {
					System.IO.Directory.CreateDirectory (@"" + Path + "/notecards");
					goto nen;
				}
				nen:
				if (File.Exists (@"" + Path + "/notecard/" + dn + ".txt")) {
					editText2.Text = "ERROR, ALREADY CREATED!";
					//goto nen1;
				} else {
					System.IO.File.WriteAllText (@"" + Path + "/notecard/" + dn + ".txt", dn);
					//nen1:		PAY ATTENTION HERE
					//goto nen1;

					//top:
					var result = GetLinesWithWord(i, @"" + Path + "/notecard/" + "/dict2.txt");		//include in apk or something or download dict

					// Display the results.
					foreach (var line in result)
					{
						//word maxlength
						const int MaxLength = 82;
						var name = line;
						if (name.Length > MaxLength)		//get word and write
							name = name.Substring(0, MaxLength); 
						Console.WriteLine(name + "\r");
						string boc = name;//this is the definition!
						string foc = i; //this is the word "FOC"		
						System.IO.File.AppendAllText (@"" + Path + "/notecard/" + "/" + dn + ".txt", foc + "\n" + boc + "\n");	 //writes back & front	//front of card


						
					//goto top;		//create new

					}
				
				}
																	
			
			


			};
				}

			public static List<string> GetLinesWithWord(string word, string filename)
			{
				List<string> result = new List<string> (); 


				using (StreamReader reader = new StreamReader (filename)) {
					string line = string.Empty; 


					while ((line = reader.ReadLine ()) != null) {

						if (line != string.Empty) {

							var parts = line.Split (new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


							if (parts.Length > 0) {
								if (parts [0].ToLower ().Trim () == word.ToLower ().Trim ()) {
									result.Add (line);
								}
							}

						}

					}

					return result;

				}



			
		}
		}
	}



