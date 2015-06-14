using System;

namespace String
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
//			Miscellaneous.Pangram p = new Miscellaneous.Pangram ();
//			bool val = p.IsPangram ("We promptly judged antique ivory buckles for the prize");

//			AnagramLength al = new AnagramLength ();
//			int val = al.PrintAnagramLength ("xxxxyyxx");

			AngryProfessor ap = new AngryProfessor ();
			ap.IsClassCancelled (4, 3);

		}
	}
}
