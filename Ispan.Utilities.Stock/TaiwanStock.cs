using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Utilities.Stock
{
	/// <summary>
	/// 股市相關的輔助類別
	/// </summary>
	public class TaiwanStock
	{
		/// <summary>
		/// 判斷是否為股票交易時間
		/// </summary>
		/// <param name="input">輸入的時間</param>
		/// <returns>是否為股票交易時間</returns>
		public bool isTradingTime(string input)
		{
			DateTime dt = Defense(input);
			DateTime start = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0);
			DateTime end = new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0);

			return (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday) ? false : (dt >= start && dt <= end) ? true : false;
		}

		private DateTime Defense(string input)
		{
			bool isDateTime = DateTime.TryParse(input, out DateTime dt);
			DateTime empty = (string.IsNullOrEmpty(input)) ? throw new Exception("時間欄位不得為空!") : dt;
			DateTime isDate = (isDateTime) ? dt : throw new Exception("請輸入正確的時間!");
			return dt;
		}
	}
}
