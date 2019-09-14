using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	class Settling
	{
		public int number { get; private set; }
		public int amountOfGuests { get; private set; }
		public string settleDate { get; private set; }
		public string unsettleDate { get; private set; }
		public int count { get; private set; }
		public int id { get; private set; }
		public int guest { get; private set; }
		public Settling(int id,int guest, int number, int amountOfGuests, string settleDate, string unsettleDate, int count)
		{
			this.guest = guest;
			this.id = id;
			this.number = number;
			this.amountOfGuests = amountOfGuests;
			this.settleDate = settleDate;
			this.unsettleDate = unsettleDate;
			this.count = count;
		}
	}
}
