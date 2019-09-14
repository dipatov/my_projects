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
	public partial class InfoGuests : Form
	{
		public delegate void obn();
		public obn upgr;

		public InfoGuests()
		{
			upgr = new obn(updat);
			InitializeComponent();
			updat();
		}

		private void InfoGuests_Load(object sender, EventArgs e)
		{

		}
		public void updat()
		{
			dataGridView1.Rows.Clear();
			if (CurrentProfile.guests == null)
			{
				CurrentProfile.guests = new List<User>();
			}
			foreach (var guest in CurrentProfile.guests)
			{
				int id = dataGridView1.Rows.Add();
				dataGridView1.Rows[id].Cells[0].Value = guest.id;
				dataGridView1.Rows[id].Cells[1].Value = guest.name;
				dataGridView1.Rows[id].Cells[2].Value = guest.lName;
				dataGridView1.Rows[id].Cells[3].Value = guest.mName;
				dataGridView1.Rows[id].Cells[4].Value = guest.phone;
				dataGridView1.Rows[id].Cells[5].Value = guest.seria;
				dataGridView1.Rows[id].Cells[6].Value = guest.number;
				dataGridView1.Rows[id].Cells[7].Value = guest.eMail;
			}
		}
	}
}
