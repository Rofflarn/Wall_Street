using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Model
{
	public class Player
	{
		public int PlayerID { get; set; }
		public string PlayerName { get; set; }
		public string PlayerColour { get; set; }
		public int Wallet { get; set; }
		public int BankAccount { get; set; }
		public List<Stock> Stocks { get; set; }
		public List<Fund> Funds { get; set; }
		public List<HappeningCard> HappeningCards { get; set; }
		public List<Street> Streets { get; set; }
		public string CarType { get; set; }
		public List<PurchaseHistory> PurchaseHistory { get; set; }

	}
}
