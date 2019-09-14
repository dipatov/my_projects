using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	class Number
	{
		public int number { get; private set; }
		public int floor { get; private set; }
		public string type { get; private set; }
		public bool free { get; private set; }
		public int countPerDay { get; private set; }
		public bool clear { get; private set; }
		public Number(int number, int floor, string type, bool free, int countPerDay, bool clear)
		{
			this.number = number;
			this.floor = floor;
			this.type = type;
			this.free = free;
			this.countPerDay = countPerDay;
			this.clear = clear;
		}
	}
}
