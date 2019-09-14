using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerForHotel
{
    class Program
    {
        static int port = 8888;
		static TcpListener listener;
		public static List<ClientObject> clients=new List<ClientObject>();
        static void Main(string[] args)
        {
			try
			{
				DB.Open();
				DBSet.fill();
				listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
				listener.Start();
				while (true)
				{
					TcpClient client = listener.AcceptTcpClient();
					ClientObject clientObject = new ClientObject(client);
					clients.Add(clientObject);
					clientObject.id = clients.Count - 1;
					Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
					clientThread.Start();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				DB.Close();
				if (listener != null)
					listener.Stop();
			}
			Console.Read();
        }
		static public void broadcastMessage(string message, Role role)
		{
			foreach(var client in clients)
			{
				if (client.role == role)
				{
					client.Send(message);
				}
			}
		}
    }
}
