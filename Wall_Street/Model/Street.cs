using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Model
{
	public class Street
	{
		public int StreetID { get; set; }
		public int StreetPrice { get; set; }
		public int RentPriceWithBuilding { get; set; }
		public int RentPriceWithoutBuilding { get; set; }
		public int BuildingCost { get; set; }
	}
}
