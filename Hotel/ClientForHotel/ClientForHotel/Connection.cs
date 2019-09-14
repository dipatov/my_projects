using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ClientForHotel
{
	public static class Connection
	{
		static string address = "127.0.0.1";
		static TcpClient client = new TcpClient();
		static int port = 8888;
		static IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(address), port);
		static NetworkStream stream;
		public static void Connect()
		{
			client.Connect(address, port);
			stream = client.GetStream();
			GuestCommands.sendOpen();
		}

		public static void Send(string message)
		{
			byte[] data = Encoding.Unicode.GetBytes(message);
			stream.Write(data, 0, data.Length);
		}

		public static void Close()
		{
			GuestCommands.sendClose();
			if (client != null)
			{
				client.Close();
			}
			if (stream != null)
			{
				stream.Close();
			}
		}

		public static void GetMessage()
		{
			while (true)
			{
				try
				{
					byte[] data = new byte[255];
					StringBuilder builder = new StringBuilder();
					int bytes = 0;
					do
					{
						bytes = stream.Read(data, 0, data.Length);
						builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
					} while (stream.DataAvailable);
					string message = builder.ToString();
					if (message == "")
					{
						continue;
					}
					string[] words = message.Split('#');
					if (words.Length == 0)
					{
						continue;
					}
					if (words[0] == "ESTABLISHED")
					{
						continue;
					}
					if (words[0] == "CLOSE")
					{
						continue;
					}
					if (words[0] == "GOODLOGIN")
					{
						Program.authorisation.Invoke(Program.authorisation.loginDelegate, words[1]);
					}
					if (words[0] == "BADLOGIN")
					{
						Program.authorisation.badLogin();
					}
					if(words[0]== "GOODANKETA")
					{
						AllForms.anketa.Invoke(AllForms.anketa.anketDelegate,words[1]);
					}
					if(words[0]== "BADREGISTRATION")
					{
						MessageBox.Show("Данный логин уже занят");
					}
					if (words[0] == "GOODREGISTRATION")
					{
						AllForms.registration.Invoke(AllForms.registration.regDelegate);
					}
					if (words[0] == "NEWTYPE")
					{
						if (Int32.Parse(words[1].Split(':')[4]) == 0)
						{
							CurrentProfile.stype = 0;
							CurrentProfile.types = new List<Type>();
							CurrentProfile.numbers = new List<Number>();
						}
						CurrentProfile.addType(words[1]);
					}
					if (words[0] == "NEWNUMBER")
					{
						CurrentProfile.addNumber(words[1]);
					}
					if(words[0]== "FOUNDBOOKED")
					{
						CurrentProfile.sizefil = Int32.Parse(words[1]);
					if (CurrentProfile.filtrs == null)
					{
						CurrentProfile.filtrs = new List<int>();
					}
						CurrentProfile.filtrs.Clear();
						if (CurrentProfile.sizefil == 0)
						{
						AllForms.booked.Invoke(AllForms.booked.closeDelegate);
						}
						else
						{ 
							GuestCommands.sendFilt(0);
						}
					}
					if(words[0]== "NEWFILTER")
					{
						CurrentProfile.addfilt(words[1]);
					}
					if(words[0]== "BADBOOK")
					{
						MessageBox.Show("Номер уже занят, извините");
					}
					if(words[0]== "GOODBOOK")
					{
						AllForms.offers.Invoke(AllForms.offers.closing);
					}
					if(words[0]== "NEWBOOKING")
					{
						CurrentProfile.addBook(words[1]);
					}
					if (words[0] == "FOUNDBOOKINGS")
					{
						CurrentProfile.sizebooking = Int32.Parse(words[1]);
						CurrentProfile.bookings = new List<Booking>();
						if (CurrentProfile.sizebooking > 0)
						{
							GuestCommands.sendNextBook(0);
						}
					}
					if(words[0]== "GOODEMAIL")
					{
						MessageBox.Show("Email успешно изменен!");
					}
					if(words[0]== "GOODPASS")
					{
						MessageBox.Show("Пароль успешно изменен!");
						AllForms.changePass.Invoke(AllForms.changePass.closDelegate);
					}
					if(words[0]== "BADPASS")
					{
						MessageBox.Show("Неправильно введен старый пароль!");
					}
					if(words[0]== "GOODPHONE")
					{
						MessageBox.Show("Телефон успешно изменен!");
					}
					if(words[0]== "UPDATEBOOKINGS")
					{
						ReseptionistCommands.sendUpdateBook();
					}
					if(words[0]== "UPDATEGUESTINGS")
					{
						CurrentProfile.sizegue = Int32.Parse(words[1]);
						CurrentProfile.guests = new List<User>();
						if (CurrentProfile.sizegue > 0)
						{
							ReseptionistCommands.sendGuest(0);
						}
					}
					if(words[0]== "NEWGUEST")
					{
						CurrentProfile.addfgue(words[1]);
					}
					if (words[0] == "UPDATESETTLING")
					{
						CurrentProfile.sizeSettle = Int32.Parse(words[1]);
						CurrentProfile.settles = new List<Settling>();
						if (CurrentProfile.sizeSettle > 0)
						{
							ReseptionistCommands.sendSettle(0);
						}
					}
					if (words[0] == "NEWSETTLE")
					{
						CurrentProfile.addSettle(words[1]);
					}
				}
				catch (Exception ex)
			{
				Close();
			}
		}
		}
	}
}
