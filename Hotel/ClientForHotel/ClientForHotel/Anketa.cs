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
	public partial class Anketa : Form
	{
		public delegate void addAnket(string message);
		public addAnket anketDelegate;
		public Anketa()
		{
			anketDelegate = new addAnket(newAnketa);
			InitializeComponent();
		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tSeria.Text.Length != 4)
			{
				MessageBox.Show("Неверный формат серии паспорта");
				return;
			}
			if (tPhone.Text.Length != 11)
			{
				MessageBox.Show("Неверный формат телефона");
				return;
			}
			if (tNumber.Text.Length != 6)
			{
				MessageBox.Show("Неверный формат номера паспорта");
				return;
			}
			if (tEmail.Text.Split(new char[]{ '@', '.' }).Length != 3)
			{
				MessageBox.Show("Неверный формат Email");
				return;
			}
			if (tName.Text == "" || tlName.Text == ""||tmName.Text == ""||tPhone.Text == ""||tSeria.Text == ""||tNumber.Text == "" || tEmail.Text == "")
			{
				MessageBox.Show("Пустое поле");
			}
			else
			{
				Connection.Send("ANKETA#" +CurrentProfile.me.login+":"+ tName.Text + ":" + tlName.Text + ":" + tmName.Text + ":" + tPhone.Text + ":" + tSeria.Text + ":" + tNumber.Text + ":" + tEmail.Text);
			}
		}

		public void newAnketa(string message)
		{
			String[] words= message.Split(':');
			CurrentProfile.me = new User(words[8],words[0], words[1], words[2], words[3], words[4], words[5], words[6], words[7]);
			AllForms.profile.filling(CurrentProfile.me);
			AllForms.menuGuest.Show();
			this.Close();
		}

		private void Anketa_Load(object sender, EventArgs e)
		{

		}

		private void tName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar)||e.KeyChar==8)
			{
				return;
			}
			e.Handled = true;
		}

		private void button1_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void tName_TextChanged(object sender, EventArgs e)
		{

		}

		private void tlName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar)||e.KeyChar==8)
			{
				return;
			}
			e.Handled = true;
		}

		private void tmName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}

		private void tSeria_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)||e.KeyChar==8)
			{
				return;
			}
			e.Handled = true;
		}

		private void tNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}

		private void tPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
