using System;

namespace Warmup
{
	public class Unfairness
	{
		public Unfairness ()
		{
			int N = Convert.ToInt32(Console.ReadLine());
			int K = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[N];

			for( int index = 0; index < N; index++)
			{
				arr[index] = Convert.ToInt32(Console.ReadLine());
			}

			Array.Sort(arr);

			int i = 0;
			int j = arr.Length - 1;
			int min = arr[i];
			int max = arr[K -1];
			int unfairness = max - min;

			while( i + K - 1 <= j )
			{
				min = arr[i];
				max = arr[i+K-1];
				if(unfairness > (max-min))
				{
					unfairness = max - min;
				}
				i++;
			}

			Console.WriteLine("{0}", unfairness);
		}
	}
}

