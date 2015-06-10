using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int j = Convert.ToInt32(Console.ReadLine());
        for(int i = j; i >0; i-- )
        {
            string s = Console.ReadLine();
            Solution.PrintRequiredDeletion(s);
        }
        
    }
    
    static void PrintRequiredDeletion(string input)
    {
        int length = input.Length;
        int deletionCount = 0;
        
        for(int i = 0; i+1 < length; i++)
        {
            if(input[i+1] == input[i])
            {
                deletionCount++;
            }
        }
        Console.WriteLine(deletionCount);

    }
}
