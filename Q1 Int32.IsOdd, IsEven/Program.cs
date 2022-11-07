using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Int32.IsOdd__IsEven
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool result = 9.IsOdd();
			result = 8.IsEven(); 
		}
	}
	public static class MyMath
	{
		public static bool IsEven(this int input) 
		{
			return input % 2 == 0;
		}
		public static bool IsOdd(this int input)
		{
			return input % 2 == 1;
		}
	}
}
