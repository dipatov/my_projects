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
	public partial class ChangePass : Form
	{
		public delegate void clos();
		public clos closDelegate;

		public ChangePass()
		{
			closDelegate = new clos(closing);
			InitializeComponent();
		}

		private void newPassword_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (newPassword.Text != ""&&oldPassword.Text!="")
			{
				GuestCommands.sendChangepass(CurrentProfile.me.login,oldPassword.Text, newPassword.Text);
			}
			else
			{
				MessageBox.Show("Пустое поле!");
			}
		}

		private void ChangePass_Load(object sender, EventArgs e)
		{

		}

		public void closing()
		{
			this.Close();
		}

		private void oldPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}

		private void newPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
