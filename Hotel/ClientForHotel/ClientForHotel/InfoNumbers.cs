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
	public partial class InfoNumbers : Form
	{
		public delegate void toupdate();
		public toupdate upd;
		public InfoNumbers()
		{
			upd = new toupdate(updat);
			InitializeComponent();
			updat();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (CurrentProfile.Role == Role.Guest)
			{
				AllForms.menuGuest.Show();
				this.Close();
			}
			if (CurrentProfile.Role == Role.Receptionis)
			{
				AllForms.receptionistMenu.Show();
				this.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void InfoNumbers_Load(object sender, EventArgs e)
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
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!AllForms.types.Visible)
			{
				AllForms.types = new Types();
				AllForms.types.Show();
			}
		}
	}
}
