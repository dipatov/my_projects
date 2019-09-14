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
	public partial class Profile : Form
	{
		public Profile()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AllForms.menuGuest.Show();
			this.Hide();
		}

		private void Profile_Load(object sender, EventArgs e)
		{

		}

		public void filling(User user)
		{
			textBox3.Text = user.login;
			textBox4.Text = user.name;
			textBox5.Text = user.lName;
			textBox6.Text = user.mName;
			textBox2.Text = user.seria;
			textBox7.Text = user.number;
			textBox8.Text = user.phone;
			textBox9.Text = user.eMail;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!AllForms.changePass.Visible)
			{
				AllForms.changePass = new ChangePass();
				AllForms.changePass.Show();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox8.ReadOnly)
			{
				textBox8.ReadOnly = !textBox8.ReadOnly;
			}
			else
			{
				if (textBox8.Text.Length != 11)
				{
					MessageBox.Show("Неверный формат телефона");
					return;
				}
				textBox8.ReadOnly = !textBox8.ReadOnly;
				GuestCommands.sendChangepho(CurrentProfile.me.id, textBox8.Text);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (textBox9.ReadOnly)
			{
				textBox9.ReadOnly = !textBox9.ReadOnly;
			}
			else
			{
				if (textBox9.Text.Split(new char[] { '@', '.' }).Length != 3)
				{
					MessageBox.Show("Неверный формат Email");
					return;
				}
				textBox9.ReadOnly = !textBox9.ReadOnly;
				GuestCommands.sendEmail(CurrentProfile.me.id, textBox9.Text);
			}
		}

		private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)||e.KeyChar==8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
