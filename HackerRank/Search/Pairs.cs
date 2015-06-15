using System;
using System.Collections.Generic;
using System.IO;
class Solution {
/* Head ends here */
static int pairs(int[] a, int k) {

    Dictionary<int, int> map = new Dictionary<int, int>();
     for(int i =0; i < a.Length; i++)
     {
         map.Add(a[i], 1);
     }
    
    int count = 0;
    foreach(int val in map.Keys)
    {
        if(map.ContainsKey(val+k))
        {
            count++;
        }
    }
    
    return count;
    }
/* Tail starts here */
static void Main(String[] args) {
        int res;
        
        String line = Console.ReadLine();
        String[] line_split = line.Split(' ');
        int _a_size = Convert.ToInt32(line_split[0]);
        int _k = Convert.ToInt32(line_split[1]);
        int[] _a = new int [_a_size];
        int _a_item;
        String move = Console.ReadLine();
        String[] move_split = move.Split(' ');
        for(int _a_i = 0; _a_i < move_split.Length; _a_i++) {
            _a_item = Convert.ToInt32(move_split[_a_i]);
            _a[_a_i] = _a_item;
        }
        
        res = pairs(_a,_k);
        Console.WriteLine(res);
        
    }
}
