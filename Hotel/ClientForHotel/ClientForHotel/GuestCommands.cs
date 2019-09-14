using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	static class GuestCommands
	{
		public static void sendOpen()
		{
			Connection.Send("CONNECTION#");
		}
		public static void sendClose()
		{
			Connection.Send("CLOSECONNECTION#");
		}
		public static void sendLogin(string login, string pass)
		{
			Connection.Send("LOGIN#" + login + ":" + pass);
		}
		public static void sendReg(string login, string pass)
		{
			Connection.Send("REGISTRATION#" + login + ":" + pass);
		}
		public static void sendBooked(string date, string days, string guests, string min, string max,string lastday)
		{
			CurrentProfile.lastbooked = date + ":" + days + ":" + guests + ":" + min + ":" + max + ":" + lastday;
			Connection.Send("BOOKED#" + date + ":" + days + ":" + guests + ":" + min + ":" + max+":"+lastday);
		}
		public static void sendFiltrs(int floor,string type,int min,int max,bool free)
		{
			Connection.Send("FILTRS#" + floor + ":" + type + ":" + min + ":" + max + ":" + (free ? 1 : 0));
		}
		public static void sendBook(int number, string date, string days, string guests, int count)
		{
			Connection.Send("BOOK#" + number + ":" + date + ":" + days + ":" + guests + ":" + count+":"+CurrentProfile.lastbooked.Split(':')[5]+":"+CurrentProfile.me.id);
		}
		public static void sendChangepass(string login,string oldpasswords,string newpassword)
		{
			Connection.Send("CHANGEPASSWORD#"+ login+":"+ oldpasswords+":"+newpassword);
		}
		public static void sendChangepho(string id,string phone)
		{
			Connection.Send("CHANGEPHONE#"+id+":" + phone);
		}
		public static void sendEmail(string id, string email)
		{
			Connection.Send("CHANGEEMAIL#"+id+":" + email);
		}
		public static void sendCancel(int id)
		{
			Connection.Send("CANCELBOOKING#" + id);
		}
		public static void sendType(int id)
		{
			Connection.Send("NEXTTYPE#" + id);
		}
		public static void sendNumber(int id)
		{
			Connection.Send("NEXTNUMBER#" + id);
		}
		public static void sendFilt(int id)
		{
			Connection.Send("NEXTFILT#" + id);
		}
		public static void sendNextBook(int id)
		{
			Connection.Send("NEXTBOOKING#" + id);
		}
		public static void sendUpdateBook(string id)
		{
			Connection.Send("UPDATEBOOKING#" + id);
		}
	}
}
