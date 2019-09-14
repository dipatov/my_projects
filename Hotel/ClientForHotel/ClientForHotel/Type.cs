using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	class Type
	{
		public string name { get; private set; }
		public int amount { get; private set; }
		public int amountOfGuest { get; private set; }
		public bool food { get; private set; }
		public Type(string name, int amount, int amountOfGuest, bool food)
		{
			this.name = name;
			this.amount = amount;
			this.amountOfGuest = amountOfGuest;
			this.food = food;
		}
	}
}
