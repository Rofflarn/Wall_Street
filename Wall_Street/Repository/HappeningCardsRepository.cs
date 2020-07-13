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
		// 26 st Bankinspektionen kort
		// 31 st Wall Street News kort
		// 27 st Bankomatkort
		public List<HappeningCard> ATMCards = new List<HappeningCard>()
		{

			new HappeningCard {HappeningCardID = 1, CardText = "ATM 1 card hello", TypeOfHappeningCard = "ATMCard" },
			new HappeningCard {HappeningCardID = 2, CardText = "ATM 2 card hello", TypeOfHappeningCard = "ATMCard" },
			new HappeningCard {HappeningCardID = 3, CardText = "ATM 3 card hello", TypeOfHappeningCard = "ATMCard" }
		};
	}

}
