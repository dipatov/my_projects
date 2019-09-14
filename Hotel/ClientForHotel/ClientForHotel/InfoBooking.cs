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
	public partial class InfoBooking : Form
	{
		
		public InfoBooking()
		{
			InitializeComponent();
			updat();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AllForms.menuGuest.Show();
			this.Hide();
		}

		private void InfoBooking_Load(object sender, EventArgs e)
		{

		}

		public void hidingInfoBooking()
		{
			this.Show();
			AllForms.menuGuest.Hide();
		}

		public void updat()
		{
			dataGridView1.Rows.Clear();
			if (CurrentProfile.bookings == null)
			{
				CurrentProfile.bookings = new List<Booking>();
			}
			foreach (var booking in CurrentProfile.bookings)
			{
				int id = dataGridView1.Rows.Add();
				dataGridView1.Rows[id].Cells[0].Value = booking.id;
				dataGridView1.Rows[id].Cells[1].Value = booking.number;
				dataGridView1.Rows[id].Cells[2].Value = booking.amountOfGuests;
				dataGridView1.Rows[id].Cells[3].Value = booking.settleDate;
				dataGridView1.Rows[id].Cells[4].Value = booking.amountOfDays;
				dataGridView1.Rows[id].Cells[5].Value = booking.count;
			}
		}
	}
}
