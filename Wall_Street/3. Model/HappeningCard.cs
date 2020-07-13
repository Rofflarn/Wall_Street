using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Wall_Street.Model
{
	public enum TypeOfHappeningCard {ATMCard, WallStreetNews, BankInspection };
	public class HappeningCard
	{
		
		public int HappeningCardID { get; set; }
		public TypeOfHappeningCard TypeOfHappeningCard { get; set; }
		public string HeadLine { get; set; }
		public string CardText { get; set; }
	}
}
