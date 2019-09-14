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
	public partial class CleanerMenu : Form
	{
		public delegate void toupdate();
		public toupdate upd;

		public CleanerMenu()
		{
			upd = new toupdate(updat);
			InitializeComponent();
			updat();
		}

		private void CleanerMenu_Load(object sender, EventArgs e)
		{

		}

		public void updat()
		{
			dataGridView1.Rows.Clear();
			if (CurrentProfile.numbers == null)
			{
				CurrentProfile.numbers = new List<Number>();
			}
			foreach (var number in CurrentProfile.numbers)
			{
				int id = dataGridView1.Rows.Add();
				dataGridView1.Rows[id].Cells[0].Value = number.number;
				dataGridView1.Rows[id].Cells[1].Value = number.floor;
				dataGridView1.Rows[id].Cells[2].Value = number.type;
				dataGridView1.Rows[id].Cells[4].Value = number.free ? "Свободен" : "Занят";
				dataGridView1.Rows[id].Cells[3].Value = number.countPerDay;
				dataGridView1.Rows[id].Cells[5].Value = number.clear ? "Чистый" : "Грязный";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Пустое поле!");
				return;
			}
			bool flag = false;
			foreach(var number in CurrentProfile.numbers)
			{
				if (Int32.Parse(textBox1.Text) == number.number)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				MessageBox.Show("Номер не найден!");
				return;
			}
			ReseptionistCommands.sendUnsettle(Int32.Parse(textBox1.Text), 1);
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
			Program.authorisation.Show();
			this.Hide();
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
