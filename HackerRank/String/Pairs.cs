using System;
using System.Collections.Generic;

namespace String
{
	public class Pairs
	{
		public Pairs ()
		{
		}

		public int FindPairs(int[] A, int K)
		{
			Dictionary<int, int> map = new Dictionary<int, int>();
			for(int i =0; i < A.Length; i++)
			{
				map.Add(A[i], 1);
			}

			int count = 0;
			foreach(int val in map.Keys)
			{
				if(map.ContainsKey(val+2))
				{
					count++;
				}
			}

			return count;
		}
	}
}

