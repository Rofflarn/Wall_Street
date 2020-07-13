using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Model
{
	public class PurchaseHistory
	{
		public int PurchaseID { get; set; }
		public List<PurchaseHistory> PurchaseHistories { get; set; }
	}
}
