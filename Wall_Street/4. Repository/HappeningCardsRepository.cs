using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_Street.Model;


namespace Wall_Street.Repository
{
	public class HappeningCardsRepository
	{
		TypeOfHappeningCard ATMCard = TypeOfHappeningCard.ATMCard;
		TypeOfHappeningCard BankInspectionCard = TypeOfHappeningCard.BankInspection;
		TypeOfHappeningCard WallStreetNewsCard = TypeOfHappeningCard.WallStreetNews;
		// 26 st Bankinspektionen kort
		// 31 st Wall Street News kort
		// 27 st Bankomatkort
		public List<HappeningCard> atmCardList() //Creates all ATM Cards into memory
		{
			var atmCardList = new List<HappeningCard>();
			var atmCard1 = new HappeningCard { HappeningCardID = 100, TypeOfHappeningCard = ATMCard, HeadLine = "Direktuttag!", CardText =  "Du får göra ett uttag på valfritt belopp" };
			atmCardList.Add(atmCard1);
			return atmCardList;
			
		}

		public List<HappeningCard> wallStreetNewsCardList() //Creates all Wall Street News Cards into memory
		{
			var wsnCardList = new List<HappeningCard>();
			var wsnCard1 = new HappeningCard { HappeningCardID = 200, TypeOfHappeningCard = WallStreetNewsCard, HeadLine = "Direkttuttag", CardText = "Direktuttag! Du får göra ett uttag på valfritt belopp" };
			wsnCardList.Add(wsnCard1);
			return wsnCardList;

		}
		public List<HappeningCard> bankInspectionCardList() //Creates all Bank Inspection Cards into memory
		{
			var biCardList = new List<HappeningCard>();
			var biCard1 = new HappeningCard { HappeningCardID = 300, TypeOfHappeningCard = BankInspectionCard, HeadLine = "Direktuttag", CardText = "Direktuttag! Du får göra ett uttag på valfritt belopp" };
			biCardList.Add(biCard1);
			return biCardList;

		}

		
	}

}
