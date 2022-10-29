using Ispan.Utilities.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwanStockTest
{
	internal class isTradingTimeTest
	{
		[TestCase("2022/10/28 9:00", true)]
		[TestCase("2022/10/28 13:31", false)]
		[TestCase("2022/10/29 9:00", false)]
		[TestCase("2022/10/29", false)]
		public void isTradingTime_是否為交易時間(string input, bool expected)
		{
			var test = new TaiwanStock();
			bool actual = test.isTradingTime(input);

			Assert.AreEqual(expected, actual);
		}
	}
}
