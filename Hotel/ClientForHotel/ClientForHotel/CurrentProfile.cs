using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	static class CurrentProfile
	{
		static public Role Role;
		static public User me { get; set; }
		static public List<Number> numbers { get; set; }
		static public int snum = 0;
		static public List<Type> types { get; set;  }
		static public int stype=0;
		static public List<Booking> bookings { get; set; }
		static public List<int> filtrs { get; set; }
		static public int sizefil;
		static public string lastbooked;
		static public int sizebooking;
		static public bool updBook;
		static public int windOpen = 0;
		static public List<User> guests { get; set; }
		static public int sizegue;
		static public bool updgue;
		static public List<Settling> settles { get; set; }
		static public int sizeSettle;
		static public bool updSettle;
		static public bool openin = false;

		public static void addType(string message)
		{
			string[] words = message.Split(':');
			types.Add(new Type(words[0], Int32.Parse(words[1]), Int32.Parse(words[2]), words[3] == "True"));
			GuestCommands.sendType(++stype);
		}
		public static void addNumber(string message)
		{
			string[] words = message.Split(':');
			numbers.Add(new Number(Int32.Parse(words[0]), Int32.Parse(words[1]), words[2], words[3] == "True", Int32.Parse(words[4]), words[5] == "True"));
			GuestCommands.sendNumber(++stype);
			if (AllForms.infoNumbers != null && AllForms.infoNumbers.Visible)
			{
				AllForms.infoNumbers.Invoke(AllForms.infoNumbers.upd);
			}
			if (AllForms.CleanerMenu != null && AllForms.CleanerMenu.Visible)
			{
				AllForms.CleanerMenu.Invoke(AllForms.CleanerMenu.upd);
			}
		}
		public static void addfilt(string message)
		{
			filtrs.Add(Int32.Parse(message));
			if (filtrs.Count < sizefil)
			{
				GuestCommands.sendFilt(filtrs.Count);
			}
			else
			{
				AllForms.booked.Invoke(AllForms.booked.closeDelegate);
			}
		}
		public static void addfgue(string message)
		{
			string[] words = message.Split(':');
			guests.Add(new User(words[0], "", words[1], words[2], words[3], words[4], words[5], words[6], words[7]));
			if (guests.Count() < sizegue)
			{
				ReseptionistCommands.sendGuest(guests.Count);
			}
			else
			{
				if (openin)
				{
					openin = false;
					AllForms.faceSettling.Invoke(AllForms.faceSettling.opening);
				}
				if (AllForms.infoGuests != null && AllForms.infoGuests.Visible)
				{
					AllForms.infoGuests.Invoke(AllForms.infoGuests.upgr);
				}
			}
		}
		public static void addSettle(string message)
		{
			string[] words = message.Split(':');
			settles.Add(new Settling(Int32.Parse(words[0]), Int32.Parse(words[1]), Int32.Parse(words[2]), Int32.Parse(words[3]), words[4], words[5], Int32.Parse(words[6])));
			if (settles.Count() < sizeSettle)
			{
				ReseptionistCommands.sendSettle(settles.Count);
			}
			else
			{
				if (AllForms.unsettling!=null&&AllForms.unsettling.Visible)
				{
					AllForms.unsettling.Invoke(AllForms.unsettling.upgr);
				}
			}
		}
		public static void addBook(string message)
		{
			string[] words = message.Split(':');
			bookings.Add(new Booking(Int32.Parse(words[0]), Int32.Parse(words[1]),Int32.Parse(words[2]),words[3],Int32.Parse(words[4]),Int32.Parse(words[5])));
			if (sizebooking > bookings.Count())
			{
				GuestCommands.sendNextBook(bookings.Count);
			}
			else if(windOpen==1)
			{
				AllForms.menuGuest.Invoke(AllForms.menuGuest.hideDelegate);
				windOpen = 0;
			}else if (windOpen == 2)
			{
				AllForms.menuGuest.Invoke(AllForms.menuGuest.hideCancDelegate);
				windOpen = 0;
			}else if (windOpen == 3)
			{
				AllForms.receptionistMenu.Invoke(AllForms.receptionistMenu.hideDelegate);
				windOpen = 0;
			}
			if (windOpen == 0)
			{
				if (AllForms.bookingSettle.Visible)
				{
					AllForms.bookingSettle.Invoke(AllForms.bookingSettle.updDeleg);
				}
			}
		}
	}
}
