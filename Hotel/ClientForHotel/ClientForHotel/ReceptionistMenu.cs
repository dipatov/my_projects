using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForHotel
{
	public partial class ReceptionistMenu : Form
	{
		public delegate void hid();
		public hid hideDelegate;

		public ReceptionistMenu()
		{
			InitializeComponent();
			hideDelegate = new hid(hidingInfoBooking);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			CurrentProfile.me = null;
			CurrentProfile.numbers = null;
			CurrentProfile.types = null;
			CurrentProfile.bookings = null;
			CurrentProfile.stype = 0;
			CurrentProfile.guests = null;
			CurrentProfile.settles = null;
			CurrentProfile.updSettle = false;
			CurrentProfile.updgue = false;
			CurrentProfile.updBook = false;
			CurrentProfile.sizegue = 0;
			CurrentProfile.guests = null;
			Program.authorisation.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!CurrentProfile.updBook)
			{
				CurrentProfile.updBook = true;
				CurrentProfile.windOpen = 3;
				ReseptionistCommands.sendUpdateBook();
			}
			else
			{
				AllForms.bookingSettle = new BookingSettle();
				AllForms.bookingSettle.Show();
				this.Hide();
			}
		}

		private void ReceptionistMenu_Load(object sender, EventArgs e)
		{

		}

		public void hidingInfoBooking()
		{
			AllForms.bookingSettle = new BookingSettle();
			AllForms.bookingSettle.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AllForms.infoNumbers = new InfoNumbers();
			AllForms.infoNumbers.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AllForms.faceSettling = new FaceSettling();
			AllForms.faceSettling.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!CurrentProfile.updSettle)
			{
				CurrentProfile.updSettle = true;
				ReseptionistCommands.sendUpdateSettle();
			}
			AllForms.unsettling = new Unsettling();
			AllForms.unsettling.Show();
			this.Hide();
		}
	}
}
