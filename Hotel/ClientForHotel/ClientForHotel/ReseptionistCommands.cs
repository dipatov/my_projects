using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	static class ReseptionistCommands
	{
		public static void sendUpdateBook()
		{
			Connection.Send("UPDATEBOOKINGRECEPTION#");
		}
		public static void sendBookSettle(int id)
		{
			Connection.Send("SETTLEBOOK#"+id);
		}
		public static void sendSettle(int id,string settle,string unsettle,int guests,int number)
		{
			Connection.Send("SETTLE#" + id + ":" + settle + ":" + unsettle + ":" + guests + ":" + number);
		}
		public static void sendGuest(int id)
		{
			Connection.Send("NEXTGUEST#" + id);
		}
		public static void sendUpdateGuests()
		{
			Connection.Send("UPDATEGUESTS#");
		}
		public static void sendSettle(int id)
		{
			Connection.Send("NEXTSETTLE#" + id);
		}
		public static void sendUpdateSettle()
		{
			Connection.Send("UPDATESETTLE#");
		}
		public static void sendUnsettle(int id,int clear)
		{
			Connection.Send("UNSETTLE#" + id+":"+clear);
		}
	}
}
