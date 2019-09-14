using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ClientForHotel
{
	static class Program
	{
		public static Authorisation authorisation;
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Connection.Connect();
			Thread thread = new Thread(new ThreadStart(Connection.GetMessage));
			thread.Start();
			Thread thread2 = new Thread(new ThreadStart(checking));
			thread2.Start();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			authorisation = new Authorisation();
			Application.Run(authorisation);
			thread.Interrupt();
			thread2.Interrupt();
		}

		static public void checking()
		{
			while (true)
			{
				if ((AllForms.booked != null && !AllForms.booked.Visible || AllForms.booked == null) &&
					(AllForms.infoBooking != null && !AllForms.infoBooking.Visible || AllForms.infoBooking == null) &&
					(AllForms.infoNumbers != null && !AllForms.infoNumbers.Visible || AllForms.infoNumbers == null) &&
					(AllForms.menuGuest != null && !AllForms.menuGuest.Visible || AllForms.menuGuest == null) &&
					(AllForms.offers != null && !AllForms.offers.Visible || AllForms.offers == null) &&
					(AllForms.profile != null && !AllForms.profile.Visible || AllForms.profile == null) &&
					(AllForms.registration != null && !AllForms.registration.Visible || AllForms.registration == null) &&
					(AllForms.types != null && !AllForms.types.Visible || AllForms.types == null) &&
					(AllForms.cancBooking != null && !AllForms.cancBooking.Visible || AllForms.cancBooking == null) &&
					(AllForms.anketa != null && !AllForms.anketa.Visible || AllForms.anketa == null) &&
					(AllForms.changePass != null && !AllForms.changePass.Visible || AllForms.changePass == null) &&
					(AllForms.bookingSettle != null && !AllForms.bookingSettle.Visible || AllForms.bookingSettle == null) &&
					(AllForms.faceSettling != null && !AllForms.faceSettling.Visible || AllForms.faceSettling == null) &&
					(AllForms.infoGuests != null && !AllForms.infoGuests.Visible || AllForms.infoGuests == null) &&
					(AllForms.receptionistMenu != null && !AllForms.receptionistMenu.Visible || AllForms.receptionistMenu == null) &&
					(AllForms.unsettling != null && !AllForms.unsettling.Visible || AllForms.unsettling == null) &&
					(AllForms.CleanerMenu != null && !AllForms.CleanerMenu.Visible || AllForms.CleanerMenu == null) &&
					(Program.authorisation != null && !Program.authorisation.Visible || Program.authorisation == null))
				{
					GuestCommands.sendClose();
					System.Environment.Exit(0);
				}
			}
		}
	}
}
