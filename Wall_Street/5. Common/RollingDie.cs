using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Common
{
	public class RollingDie
	{
		private Random rnd = new Random();
		

		public int OneDice()
		{
			return rnd.Next(6) + 1;
		}

		public string TwoDice()
		{
			int dice1 = OneDice();
			int dice2 = OneDice();
			return dice1.ToString() + " " + dice2.ToString(); //Visar varje tärning i stringformat
		}

		public string ThreeDice()
		{
			int dice1 = OneDice();
			int dice2 = OneDice();
			int dice3 = OneDice();
			return dice1.ToString() + " " + dice2.ToString() + " " + dice3.ToString(); //Visar varje tärning i stringformat
		}
	}
}
