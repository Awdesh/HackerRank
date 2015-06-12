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
}
