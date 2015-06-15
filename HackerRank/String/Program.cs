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

//			AngryProfessor ap = new AngryProfessor ();
//			ap.IsClassCancelled (4, 3);

//			Reverese r = new Reverese ();
//			r.ReverseInt (1534236469);
//			Convert.ToInt32 (Console.ReadLine ());
//			string[] inputs = Console.ReadLine().Split(' ');
//			int[] ar = new int[inputs.Length];
//			int index = 0;
//			foreach (string s in inputs) {
//				ar [index] = Convert.ToInt32 (s);
//				index++;
//			}
//
//			Array.Sort(ar);
//
//			int n = ar.Length;
//			int gone = 0;
//			int cut = 0;
//			for (int i = 0; i < n; i += 1)
//			{
//				if (cut < ar[i]) 
//				{
//					Console.WriteLine(n - gone);
//					cut = ar[i];
//				}
//				gone += 1;
//			}

			int[] A = new int[] {363374326, 364147530, 61825163, 1073065718, 1281246024, 1399469912, 428047635, 491595254, 879792181, 1069262793};
			Pairs p = new Pairs ();
			p.FindPairs (A, 2);
	   }
    }
}
