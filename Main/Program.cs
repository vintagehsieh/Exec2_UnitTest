using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispan.Utilities.Stock;

namespace Main
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var input = new TaiwanStock();
			Console.Write("請輸入欲判斷的時間(範例: 2020/1/1 9:00:00): ");
			try
			{
				bool result = input.isTradingTime(Console.ReadLine());
				Console.WriteLine(result);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			
		}
	}
}
