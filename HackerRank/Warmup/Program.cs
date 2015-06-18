using System;
using System.Text;
using System.Collections.Generic;

namespace Warmup
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int N = Convert.ToInt32(Console.ReadLine());
			string S = Console.ReadLine();
			int K = Convert.ToInt32(Console.ReadLine());

			string s = Warmup.CaesarCipher.EncryptString(K, S);
			Console.WriteLine ("{0}", s);
		}


//		static int MakePalindrome(string s)
//		{ 
//			int i = 0; 
//			int L = s.Length;
//			int j = L - 1;
//
//			char[] chArr = s.ToCharArray ();
//			int count = 0;
//
//			while(i < j)
//			{
//				int k = i;
//				int l = j;
//				while(chArr[k] != chArr[l])
//				{
//					if (chArr [l] != 'a' && chArr[k] < chArr[l] ) {
//						int c = chArr [l] - 1;
//						chArr [l] = (char)c;
//						count++;
//					} else if (chArr [k] != 'a') {
//						int c = chArr [k] - 1;
//						chArr [k] = (char)c;
//						count++;
//					} else {
//						break;
//					}
//				}
//				j--;
//				i++;
//			}
//			return count;
//		}
	}
}
