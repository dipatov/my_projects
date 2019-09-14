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
	public partial class Types : Form
	{
		public delegate void toupdate();
		public toupdate upd;

		public Types()
		{
			upd = new toupdate(updat);
			InitializeComponent();
			updat();
		}

		private void Types_Load(object sender, EventArgs e)
		{

		}

		public void updat()
		{
			dataGridView1.Rows.Clear();
			if (CurrentProfile.types == null)
			{
				CurrentProfile.types = new List<Type>();
			}
			foreach (var type in CurrentProfile.types)
			{
				int id = dataGridView1.Rows.Add();
				dataGridView1.Rows[id].Cells[0].Value = type.name;
				dataGridView1.Rows[id].Cells[1].Value = type.amount;
				dataGridView1.Rows[id].Cells[2].Value = type.amountOfGuest;
				dataGridView1.Rows[id].Cells[3].Value = type.food ? "Присутствует" : "Отсутствует";
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
