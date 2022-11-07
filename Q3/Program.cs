using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    //針對 string 寫一個擴充方法 ToInt(this string value, int defaultValue), 可以將 string 轉換成 int 型別, 如果無法轉型成功, 傳回 defaultValue

	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "1234";
			int result = value.IsInt(-1);
			Console.WriteLine(result);

			string value2 = "aaaa";
			result = value2.IsInt(-1);
			Console.WriteLine(result);
		}
	}
	public static class MyStringProperty 
	{
		public static int IsInt (this string input ,int defaultValue)
		{
			return int.TryParse(input,out int v)? v:defaultValue;
		}
	}
}
