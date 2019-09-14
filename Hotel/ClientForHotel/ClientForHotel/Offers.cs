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
	public partial class Offers : Form
	{
		public delegate void cl();
		public cl closing;

		List<Number> numbers;
		public Offers()
		{
			closing = new cl(clos);
			InitializeComponent();
			updat();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AllForms.menuGuest.Show();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!AllForms.types.Visible)
			{
				AllForms.types = new Types();
				AllForms.types.Show();
			}
		}

		private void Offers_Load(object sender, EventArgs e)
		{

		}

		public void updat()
		{
			dataGridView1.Rows.Clear();
			numbers=new List<Number>();
			foreach (var number in CurrentProfile.numbers)
			{
				numbers.Add(number);
			}
			foreach (var type in CurrentProfile.filtrs)
			{
				foreach (var number in CurrentProfile.numbers)
				{
					if (number.number == type)
					{
						numbers.Remove(number);
					}
				}
			}
			foreach (var number in numbers)
			{
				int id = dataGridView1.Rows.Add();
				dataGridView1.Rows[id].Cells[0].Value = number.number;
				dataGridView1.Rows[id].Cells[1].Value = number.floor;
				dataGridView1.Rows[id].Cells[2].Value = number.type;
				dataGridView1.Rows[id].Cells[3].Value = number.countPerDay * Int32.Parse(CurrentProfile.lastbooked.Split(':')[1]);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = false;
			int countp=0;
			foreach(var num in numbers)
			{
				if (Int32.Parse(Numb.Text) == num.number)
				{
					flag = true;
					countp = num.countPerDay;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("Извините, но данные номер не найден в списке");
				Numb.Text = "";
			}
			else
			{
				string[] words = CurrentProfile.lastbooked.Split(':');
				GuestCommands.sendBook(Int32.Parse(Numb.Text),words[0],words[1],words[2],countp*Int32.Parse(words[1]));
			}
		}

		public void clos()
		{
			MessageBox.Show("Номер успешно забронирован!");
			GuestCommands.sendUpdateBook(CurrentProfile.me.id);
			AllForms.menuGuest.Show();
			this.Close();
		}

		private void Numb_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
