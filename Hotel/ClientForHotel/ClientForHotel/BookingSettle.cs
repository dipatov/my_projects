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
	public partial class BookingSettle : Form
	{
		public delegate void upd();
		public upd updDeleg;

		public BookingSettle()
		{
			updDeleg = new upd(updat);
			InitializeComponent();
			updat();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AllForms.receptionistMenu.Show();
			this.Close();
		}

		private void BookingSettle_Load(object sender, EventArgs e)
		{

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

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Пустое поле!");
				return;
			}
			bool flag = false;
			foreach(var book in CurrentProfile.bookings)
			{
				if (book.id == Int32.Parse(textBox1.Text))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				MessageBox.Show("Бронь не найдена!");
				return;
			}
			ReseptionistCommands.sendBookSettle(Int32.Parse(textBox1.Text));
			AllForms.receptionistMenu.Show();
			this.Close();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
