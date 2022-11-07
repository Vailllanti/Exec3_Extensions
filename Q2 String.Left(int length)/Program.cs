using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_String.Left_int_length_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string words = "aaaaaa";
			string result = words.Lift(4);
			Console.WriteLine(result);
		}

	}
	public static class MyString 
	{
		public static string Lift(this string value,int length)
		{
			if (string.IsNullOrEmpty(value)) return string.Empty;
			if (length < 0) return string.Empty;
			if (value.Length < length) return value;
			return value.Substring(0, length);
		}
	}
}
