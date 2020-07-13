using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Model
{
	public class Bank
	{
		public int BankID { get; set; }
		public string BankName { get; set; }
		public List<Stock> Stocks { get; set; }
		public List<Fund> Funds { get; set; }
	}
}
