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
	public partial class Booked : Form
	{
		public delegate void closing();
		public closing closeDelegate;

		public Booked()
		{
			closeDelegate = new closing(clos);
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AllForms.menuGuest.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (amountDays.Text != "" && guests.Text != "")
			{
				DateTime lastda = dateT.Value.AddDays(double.Parse(amountDays.Text));
				string lday = lastda.Day + "." + lastda.Month + "." + lastda.Year;
				if (minim.Text == "")
				{
					minim.Text = "0";
				}
				if (maxim.Text == "")
				{
					maxim.Text = "100000000";
				}
				GuestCommands.sendBooked(dateT.Text, amountDays.Text, guests.Text, minim.Text, maxim.Text, lday);
				if (minim.Text == "0")
				{
					minim.Text = "";
				}
				if (maxim.Text == "100000000")
				{
					maxim.Text = "";
				}
			}
			else
			{
				MessageBox.Show("Пустые необходимые поля для заполнения");
			}
		}

		private void Booked_Load(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		public void clos()
		{
			AllForms.offers = new Offers();
			AllForms.offers.Show();
			this.Close();
		}

		private void amountDays_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}

		private void guests_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}

		private void minim_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}

		private void maxim_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
