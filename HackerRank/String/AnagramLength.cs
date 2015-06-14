using System;

namespace String
{
	/// <summary>
	/// TODO-: Not complete, Anagram length.
	/// </summary>
	public class AnagramLength
	{
		public AnagramLength ()
		{
		}

		/// <summary>
		/// Prints the length of the anagram.
		/// </summary>
		/// <returns>The anagram length.</returns>
		/// <param name="s">S.</param>
	    public int PrintAnagramLength(string s)
		{
			int len = s.Length;
			int l1 = len / 2;
			int i = 0;
			int j = l1;
			int count = 0;
			int totalCount = 0;

			while(i < l1 && j < len)
			{
				bool flag = false;
				int k = l1;
				while(k < len)
				{
					if(s[i] == s[k])
					{
						flag = true;
						break;
					}    
					k++;
				}

				if(!flag)
				{
					count++;
				}

				totalCount += count;
				count = 0;

				i++;
				j++;
			}

			while(j < len || i < l1)
			{
				totalCount++;
				i++;
				j++;
			}

			if(totalCount > l1)
			{
				return -1;
			}
			else
			{
				return totalCount;
			}
		}
	}
}

