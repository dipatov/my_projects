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
	public partial class FaceSettling : Form
	{
		public delegate void op();
		public op opening;

		public FaceSettling()
		{
			opening = new op(ope);
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AllForms.receptionistMenu.Show();
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Id.Text == "" || guests.Text == "" || number.Text == "")
			{
				MessageBox.Show("Пустое поле");
				return;
			}
			bool flag = false;
			foreach(var guest in CurrentProfile.guests)
			{
				if (Id.Text == guest.id)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("Гость не найден!");
				return;
			}
			flag = false;
			foreach (var numbe in CurrentProfile.numbers)
			{
				if (numbe.number == Int32.Parse(number.Text))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("Номер не найден!");
				return;
			}
			ReseptionistCommands.sendSettle(Int32.Parse(Id.Text), SettleDate.Text, UnsettleDate.Text, Int32.Parse(guests.Text), Int32.Parse(number.Text));
			AllForms.receptionistMenu.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!CurrentProfile.updgue)
			{
				CurrentProfile.updgue = true;
				CurrentProfile.openin = true;
				ReseptionistCommands.sendUpdateGuests();
			}
			else
			{
				if (!AllForms.infoGuests.Visible)
				{
					AllForms.infoGuests = new InfoGuests();
					AllForms.infoGuests.Show();
				}
			}
		}

		private void FaceSettling_Load(object sender, EventArgs e)
		{

		}

		public void ope()
		{
			AllForms.infoGuests = new InfoGuests();
			AllForms.infoGuests.Show();
		}

		private void Id_KeyPress(object sender, KeyPressEventArgs e)
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

		private void number_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
