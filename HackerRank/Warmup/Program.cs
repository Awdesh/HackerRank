using System;

namespace Warmup
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			int N = Convert.ToInt32(Console.ReadLine());
			int K = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[N];

			for( int index = 0; index < N; index++)
			{
				arr[index] = Convert.ToInt32(Console.ReadLine());
			}


			int i = 0;
			int j = arr.Length - 1;
			int min = Math.Min(arr[i],Math.Min(arr[j],arr[j-1]));
			int max = Math.Max(arr[i],Math.Max(arr[j],arr[j-1]));
			int unfairness = max - min;

			j = j - 1;
			while(i > N)
			{
				if(j-1 >= 0)
				{
					while(Math.Max(arr[i],Math.Max(arr[j],arr[j-1])) > max && j-1 >= 0 )
						j--;
					if( unfairness > Math.Max(arr[i],Math.Max(arr[j],arr[j-1])) - Math.Min(arr[i],Math.Min(arr[j],arr[j-1])))
						unfairness = Math.Max(arr[i],Math.Max(arr[j],arr[j-1])) - Math.Min(arr[i],Math.Min(arr[j],arr[j-1]));
				}
				i++;
			}

			Console.WriteLine("{0}", unfairness);
		}
	}
}
