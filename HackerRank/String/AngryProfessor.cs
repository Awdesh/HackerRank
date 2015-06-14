using System;

namespace String
{
	public class AngryProfessor
	{
		public AngryProfessor ()
		{
		}

		public void IsClassCancelled(int N, int K)
		{
			int i = 0;
			int beforeCount = 0;
			string[] inputs = Console.ReadLine().Split(' ');
			while(i < N)
			{
				int val = Convert.ToInt32(inputs[i]);
				if( val <= 0)
				{
					beforeCount++;
				}
				i++;
			}

			if(beforeCount >= K)
				Console.WriteLine("NO");
			else
				Console.WriteLine("YES");
		}

	}
}

