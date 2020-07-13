using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_Street.Common;
using Wall_Street.Model;
using Wall_Street.Repository;

namespace Wall_Street
{
	public class Program
	{
		
		static void Main(string[] args)
		{
			//var playerList = new List<Player>();
			//Player player = new Player();
			//player.CreatePlayer("Niklas", "Blue", 1);

			StreetRepository CoroprateGroups = new StreetRepository();
			
			

			//RollingDie roll = new RollingDie();
			//Console.WriteLine(roll.OneDice());
			//Console.WriteLine(roll.TwoDice());
			Console.ReadKey();
			//BanksStocksFundsRepository Banks = new BanksStocksFundsRepository();
			//List<Bank> list = new List<Bank>(Banks.CreateBankList());
			//for (var i = 0; i < list.Count; i++)
			//{ Console.WriteLine(i); }
			
			
		}
	}
}
