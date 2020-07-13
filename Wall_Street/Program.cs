using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_Street.Model;
using Wall_Street.Repository;

namespace Wall_Street
{
	public class Program
	{
		
		static void Main(string[] args)
		{
			
			Banks_Stocks_FundsRepository Banks = new Banks_Stocks_FundsRepository();
			List<Bank> list = new List<Bank>(Banks.CreateBankList());
			for (var i = 0; i < list.Count; i++)
			{ Console.WriteLine(i); }
			
			
		}
	}
}
