using System;

namespace Miscellaneous
{
	public class Pangram
	{
		public Pangram ()
		{
		}

		public bool IsPangram(string s)
		{
			int l = s.Length;
			bool[] booleanFlags = new bool[128];
			for(int i = 0; i < s.Length; i++)
			{
				char c = s [i];
				int j = s[i];
				booleanFlags[j] = true;
			}

			for(int i = 65; i < 91; i++)
			{
				if((booleanFlags[i] == false && booleanFlags[i+32] == false))
					return false;    
			}

			for(int j = 97; j < 122; j++)
			{
				if((booleanFlags[j] == false && booleanFlags[j-32] == false))
					return false;    
			}
			return true;     
		}
	}
}