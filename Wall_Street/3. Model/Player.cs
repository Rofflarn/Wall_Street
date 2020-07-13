using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_Street.Model;

namespace Wall_Street.Model
{
	public enum CarType { SportsCar, ElectricCar, NoCar, ScrapVehicle };
	public enum PlayerColour { Blue, Black, Green, Red, Yellow, White }
	public class Player
	{
		public int PlayerID { get; set; }
		public string PlayerName { get; set; }
		public PlayerColour PlayerColour { get; set; }
		public int Wallet { get; set; }
		public int BankAccount { get; set; }
		public int Loan { get; set; }
		public List<Stock> Stocks { get; set; }
		public List<Fund> Funds { get; set; }
		public List<HappeningCard> HappeningCards { get; set; }
		public List<Street> Streets { get; set; }
		public CarType Cartype { get; set; }
		public List<PurchaseHistory> PurchaseHistory { get; set; }
		public List<CorporateGroup> Coroprategroup { get; set; }


		public Player CreatePlayer(string playerName, int playerID, PlayerColour playerColour)
		{
			CarType noCar = Model.CarType.NoCar;
			
			var fundList = new List<Fund>();
			var stockList = new List<Stock>();
			var purchaseHistory = new List<PurchaseHistory>();
			var happeningCards = new List<HappeningCard>();
			var streetList = new List<Street>();
			var corporateGroupList = new List<CorporateGroup>();
			var player = new Player
			{
				PlayerID = playerID,
				PlayerName = playerName,
				PlayerColour = playerColour,
				Cartype = noCar,
				BankAccount = 0,
				Loan = 0,
				Wallet = 600000,				
				Funds = fundList,
				Stocks = stockList,
				HappeningCards = happeningCards,
				Streets = streetList,
				Coroprategroup = corporateGroupList,
				PurchaseHistory = purchaseHistory

			};

			return player;
		}

	}
}
