using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;

namespace ServerForHotel
{
	public class ClientObject
	{
		public int id;
		public List<string> filters = new List<string>();
		public List<string> bookings = new List<string>();
		public TcpClient client;
		public Role role;

		NetworkStream stream = null;

		public ClientObject(TcpClient tcpClient)
		{
			client = tcpClient;
		}

		public void Process()
		{
			try
			{
				stream = client.GetStream();
				byte[] data = new byte[225];
				while (true)
				{
					StringBuilder builder = new StringBuilder();
					int bytes = 0;
					do
					{
						bytes = stream.Read(data, 0, data.Length);
						builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
					}
					while(stream.DataAvailable);
					Console.WriteLine("FROMUSER"+id+":" +builder.ToString());
					Send(Order(builder.ToString()));
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Program.clients.Remove(this);
				if (stream != null)
				{
					stream.Close();
				}
				if(client != null)
				{
					client.Close();
				}
			}
		}

		public string Order(string message)
		{
			string zapros=message.Split('#')[0];
			if (zapros == "LOGIN")
			{
				string mess= DBSet.Login(message.Split('#')[1],this);
				return mess;
			}
			if(zapros== "CONNECTION")
			{
				return "ESTABLISHED#";
			}
			if (zapros == "CLOSECONNECTION")
			{
				return "";
			}
			if (zapros == "REGISTRATION")
			{
				return DBSet.Registration(message.Split('#')[1]);
			}
			if(zapros== "ANKETA")
			{
				return DBSet.newGuest(message.Split('#')[1],this);
			}
			if(zapros== "NEXTTYPE")
			{
				sendType(Int32.Parse(message.Split('#')[1]));
				return "";
			}
			if (zapros == "NEXTNUMBER")
			{
				sendNumber(Int32.Parse(message.Split('#')[1]));
				return "";
			}
			if (zapros == "BOOKED")
			{
				DBSet.filters(this, message.Split('#')[1]);
				return "FOUNDBOOKED#"+filters.Count;
			}
			if(zapros== "NEXTFILT")
			{
				return filters[Int32.Parse(message.Split('#')[1])];
			}
			if(zapros== "BOOK"){
				return DBSet.addbook(message.Split('#')[1]);
			}
			if(zapros== "UPDATEBOOKING")
			{
				DBSet.booklist(this, message.Split('#')[1]);
				return "";
			}
			if (zapros== "NEXTBOOKING")
			{
				return bookings[Int32.Parse(message.Split('#')[1])];
			}
			if(zapros == "NEXTSETTLE")
			{
				return DBSet.allSetles[Int32.Parse(message.Split('#')[1])];
			}
			if (zapros == "NEXTGUEST")
			{
				return DBSet.allGuest[Int32.Parse(message.Split('#')[1])];
			}
			if (zapros== "CANCELBOOKING")
			{
				DBSet.dellbook(message.Split('#')[1]);
				return "";
			}
			if(zapros== "CHANGEPASSWORD")
			{
				return DBSet.changePass(message.Split('#')[1]);
			}
			if(zapros== "CHANGEEMAIL")
			{
				return DBSet.changeEmail(message.Split('#')[1]);
			}
			if (zapros == "CHANGEPHONE")
			{
				return DBSet.changePhone(message.Split('#')[1]);
			}
			if (zapros == "UPDATEBOOKINGRECEPTION")
			{
				DBSet.booklist(this);
				return "";
			}
			if (zapros== "SETTLEBOOK")
			{
				DBSet.booksettle(message.Split('#')[1]);
				return "";
			}
			if(zapros== "SETTLE")
			{
				DBSet.settle(message.Split('#')[1]);
				return "";
			}
			if(zapros== "UPDATEGUESTS")
			{
				return "UPDATEGUESTINGS#" + DBSet.allGuest.Count;
			}
			if (zapros == "UPDATESETTLE")
			{
				return "UPDATESETTLING#" + DBSet.allSetles.Count;
			}
			if(zapros== "UNSETTLE")
			{
				DBSet.unsettle(message.Split('#')[1]);
				return "";
			}
			return "ERROR#";
		}

		public void Send(string message)
		{
			if (message == "")
			{
				return;
			}
			Console.WriteLine("TOUSER" + id + ":" + message);
			byte[] data = new byte[225];
			data = Encoding.Unicode.GetBytes(message);
			stream.Write(data, 0, data.Length);
		}
		
		public void sendType(int id)
		{
			try
			{
				Send(DBSet.allTypes[id].ToString());
			}catch(Exception ex)
			{

			}
		}

		public void sendNumber(int id)
		{
			try
			{
				Send(DBSet.allTypes[id].ToString());
			}
			catch (Exception ex)
			{

			}
		}
	}
}
