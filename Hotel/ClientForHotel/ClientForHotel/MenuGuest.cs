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
	public partial class MenuGuest : Form
	{
		public delegate void hid();
		public hid hideDelegate,hideCancDelegate;
		public MenuGuest()
		{
			InitializeComponent();
			hideDelegate = new hid(hidingInfoBooking);
			hideCancDelegate = new hid(hidingCand);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AllForms.profile.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AllForms.booked = new Booked();
			AllForms.booked.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!CurrentProfile.updBook)
			{
				CurrentProfile.windOpen = 2;
				CurrentProfile.updBook = true;
				GuestCommands.sendUpdateBook(CurrentProfile.me.id);
			}
			else
			{
				AllForms.cancBooking = new CancBooking();
				AllForms.cancBooking.Show();
				this.Hide();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!CurrentProfile.updSettle)
			{
				CurrentProfile.updSettle = true;
				ReseptionistCommands.sendUpdateSettle();
			}
			AllForms.infoNumbers = new InfoNumbers();
			AllForms.infoNumbers.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!CurrentProfile.updBook)
			{
				CurrentProfile.updBook = true;
				CurrentProfile.windOpen = 1;
				GuestCommands.sendUpdateBook(CurrentProfile.me.id);
			}
			else
			{
				AllForms.infoBooking = new InfoBooking();
				AllForms.infoBooking.Show();
				this.Hide();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			CurrentProfile.me = null;
			CurrentProfile.numbers = null;
			CurrentProfile.types = null;
			CurrentProfile.bookings = null;
			CurrentProfile.stype = 0;
			Program.authorisation.Show();
			this.Hide();
		}

		private void MenuGuest_Load(object sender, EventArgs e)
		{

		}

		public void hidingInfoBooking()
		{
			AllForms.infoBooking = new InfoBooking();
			AllForms.infoBooking.Show();
			this.Hide();
		}

		public void hidingCand()
		{
			AllForms.cancBooking = new CancBooking();
			AllForms.cancBooking.Show();
			this.Hide();
		}
	}
}
