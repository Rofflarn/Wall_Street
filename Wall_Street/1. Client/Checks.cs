using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Client
{
	public class Checks
	{
		//When you land on a Street / property, these checks will kick in to see if the player is able to buy the property, owns it or has to pay rent.
		public bool IsPropertyOwnedByPlayer()
		{
			return true;
		}
		public bool IsPropertyOwnedByOtherPlayer()
		{
			return true;
		}
		public bool IsPropertyBuyable()
		{
			return true;
		}
	}
}
