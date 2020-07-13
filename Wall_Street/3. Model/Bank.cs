using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Model
{
	public enum BankName {ItaliaBank, LondonBank, MonacoBank, FranceBank, BundesBank, WallStreetBank }
	public class Bank
	{
		public int BankID { get; set; }
		public BankName BankName { get; set; }
		public List<Stock> Stocks { get; set; }
		public List<Fund> Funds { get; set; }
	}
}
