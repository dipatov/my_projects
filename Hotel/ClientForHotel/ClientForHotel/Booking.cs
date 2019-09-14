using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	class Booking
	{
		public int number { get; private set; }
		public int amountOfGuests { get; private set; }
		public string settleDate { get; private set; }
		public int amountOfDays { get; private set; }
		public int count { get; private set; }
		public int id { get; private set; }
		public Booking(int id,int number, int amountOfGuests, string settleDate, int amountOfDays, int count)
		{
			this.id = id;
			this.number = number;
			this.amountOfGuests = amountOfGuests;
			this.settleDate = settleDate;
			this.amountOfDays = amountOfDays;
			this.count = count;
		}
	}
}
