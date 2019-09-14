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
	public partial class Registration : Form
	{
		public delegate void reg();
		public reg regDelegate;

		public Registration()
		{
			regDelegate = new reg(goodreg);
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text != "")
			{
				GuestCommands.sendReg(textBox1.Text, textBox2.Text);
			}
			else
			{
				MessageBox.Show("Пустое поле");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			Program.authorisation.Show();
			this.Hide();
		}

		public void goodreg()
		{
			MessageBox.Show("Вы успешно зарегистрированы");
			Program.authorisation.Show();
			this.Close();
		}

		public void badreg()
		{

		}

		private void Registration_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
			{
				return;
			}
			e.Handled = true;
		}
	}
}
