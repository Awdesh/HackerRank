using System;
using System.Text;

namespace Warmup
{
	public class CaesarCipher
	{
		public CaesarCipher ()
		{
		}

		public static string EncryptString(int K, string input)
		{
			char[] charArray = input.ToCharArray();
			int rotation = CalculateSmallIndex (K);

			StringBuilder sb = new StringBuilder();
			foreach(char c in charArray)
			{
				int i = Convert.ToInt32 (c);
				char letter = c;

				// Check for Capital Case letters.
				if (c >= 65 && c <= 90) 
				{
					int rot = rotation;
					rot += c;

					if (rot > 90) 
					{
						rot -= 90;
						letter = (char)(64 + rot);
					}
					else
						letter = (char)rot;
				}

				// Check for Small Case letters.
				else if (c >= 97 && c <= 122) 
				{
					int rot = rotation;
					rot += c;
					if (rot > 122) 
					{
						rot -= 122;
						letter = (char)(96 + rot);
					}
					else
						letter = (char)rot;

				}

				sb.Append (letter);
			}

			return sb.ToString();
		}

		// Helper method to identify rotation needed inside the alphabet range.
		static int CalculateSmallIndex(int k)
		{
			while(k >= 26) 
			{
				k = Math.Abs(k-26);
			}
			return k;
		}
	}
}

