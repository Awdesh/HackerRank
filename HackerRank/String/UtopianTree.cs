using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            PrintHeight(h);
        }
    }
    
    static void PrintHeight(int h)
    {
        int height = 1;
        for(int i = 1; i <= h; i++)
        {
            if(i%2 != 0)
                height = height * 2;
            else
                height += 1;
        }
        Console.WriteLine("{0}", height);
    }

	// recursion
    static int PrintHeightRecursion(int h)
	{
		int growth = 0;
		
		if(h == 0)
			return 1;
		else if(h % 2 == 1)
			growth += (2 * PrintHeightRecursion(h-1));
		else
			growth = growth + (1 * PrintHeightRecursion(h-1);
	}
}
