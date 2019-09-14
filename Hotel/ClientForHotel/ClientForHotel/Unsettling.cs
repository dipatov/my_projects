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
	public partial class Unsettling : Form
	{
		public delegate void obn();
		public obn upgr;

		public Unsettling()
		{
			upgr = new obn(updat);
			InitializeComponent();
			updat();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AllForms.receptionistMenu.Show();
			this.Close();
		}

		private void Unsettling_Load(object sender, EventArgs e)
		{

		}
		public void updat()
		{
			dataGridView1.Rows.Clear();
			if (CurrentProfile.settles == null)
			{
				CurrentProfile.settles = new List<Settling>();
			}
			foreach (var settle in CurrentProfile.settles)
			{
				int id = dataGridView1.Rows.Add();
				dataGridView1.Rows[id].Cells[0].Value = settle.id;
				dataGridView1.Rows[id].Cells[1].Value = settle.guest;
				dataGridView1.Rows[id].Cells[2].Value = settle.number;
				dataGridView1.Rows[id].Cells[3].Value = settle.amountOfGuests;
				dataGridView1.Rows[id].Cells[4].Value = settle.settleDate;
				dataGridView1.Rows[id].Cells[5].Value = settle.unsettleDate;
				dataGridView1.Rows[id].Cells[6].Value = settle.count;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Пустое поле!");
				return;
			}
			foreach (var settle in CurrentProfile.settles)
			{
				if (settle.id == Int32.Parse(textBox1.Text))
				{
					ReseptionistCommands.sendUnsettle(settle.number, 0);
					AllForms.receptionistMenu.Show();
					this.Close();
					return;
				}
			}
			MessageBox.Show("Id не найдено!");
			textBox1.Text = "";
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
