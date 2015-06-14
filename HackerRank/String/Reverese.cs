using System;

namespace String
{
	public class Reverese
	{
		public Reverese ()
		{
		}

		public int ReverseInt(int x) {
			if (x == 0) {
				return 0;
			}
			bool isNeg = false;
			if(x < 0)
			{
				x *= -1;
				isNeg = true;
			}

			int r = 0;
			int rev = 0;
			int left = x;

			try
			{
				while(left > 0)
				{
					r = left %10;
					rev = rev*10 + r;
					left = left/10;    
				}
			}

			catch(IndexOutOfRangeException ex) {
				Console.WriteLine ("Index out of range");
			}

			if(isNeg)
			{
				rev *= -1;
			}

			return rev;
		}
	}
}

