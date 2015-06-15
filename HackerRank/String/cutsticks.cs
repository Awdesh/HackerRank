using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
		Convert.ToInt32 (Console.ReadLine ());
        string[] inputs = Console.ReadLine().Split(' ');
		int[] ar = new int[inputs.Length];
		int index = 0;

		// In order for Array.sort to work correctly, we should convert string array into an int array.
		foreach (string s in inputs) 
		{
			ar [index] = Convert.ToInt32 (s);
			index++;
		}


		Array.Sort(ar);
		int smallestCut = ar[0];
		int largestCut = ar [ar.Length - 1];

		while(largestCut > 0)
		{
			int cutCount = 0;
			int left = 0;
			for(int i = 0; i < ar.Length; i++)
			{
				if (ar [i] == 0)
					continue;

				int val = ar[i] - smallestCut;

				if
				{
					// flag which keep tracks last element left inside an array.
					left += 1;
					ar [i] = val;
					cutCount++;
				}
			}

			for(int i = 0; i < ar.Length; i++)
			{
				if (ar [i] > 0) {
					smallestCut = ar [i];
					break;
				}
			}


			if (left == 1) 
			{
				ar [ar.Length - 1] = largestCut;
				Console.WriteLine("{0}", 1);
				break;
			}

			Console.WriteLine("{0}", cutCount);
			largestCut = ar[ar.Length - 1];
		}	

		// Another Solution from hacker rank.
		int n = ar.Length;
		int gone = 0;
		int cut = 0;
		for (int i = 0; i < n; i += 1)
		{
			// since we don't need to update input array we just check for prev index number i.e. cut
			// if its smaller than current element then we have to subtract it and we can print.
			if (cut < ar[i]) 
			{
				Console.WriteLine(n - gone);
				cut = ar[i];
			}
			gone += 1;
		}
    }
}
