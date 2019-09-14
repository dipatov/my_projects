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
	public partial class Authorisation : Form
	{
		public delegate void addToLogin(string message);
		public addToLogin loginDelegate;
		public delegate void closing();
		public closing clos;
		public Authorisation()
		{
			clos = new closing(Close);
			loginDelegate = new addToLogin(toLogin);
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text != "")
			{
				GuestCommands.sendLogin(textBox1.Text, textBox2.Text);
			}
			else
			{
				MessageBox.Show("Пустое поле");
			}
		}

		public void badLogin()
		{
			MessageBox.Show("Неверный логин или пароль");
		}

		public void toLogin(string message)
		{
			string[] words = message.Split(':');
			if (words[1] == "Guest")
			{
				CurrentProfile.Role = Role.Guest;
				CurrentProfile.me = new User(words[9],words[0], words[2], words[3], words[4], words[5], words[6], words[7], words[8]);
				CurrentProfile.numbers = new List<Number>();
				CurrentProfile.snum = 0;
				CurrentProfile.bookings = new List<Booking>();
				CurrentProfile.stype = 0;
				CurrentProfile.types = new List<Type>();
				GuestCommands.sendType(0);
				CurrentProfile.updBook = false;
				AllForms.profile.filling(CurrentProfile.me);
				if (CurrentProfile.me.name == "")
				{
					MessageBox.Show("Пожалуйста, заполните анкету");
					AllForms.anketa = new Anketa();
					AllForms.anketa.Show();
				}
				else
				{
					AllForms.menuGuest.Show();
				}
				textBox1.Text = "";
				textBox2.Text = "";
				this.Hide();
			}
			if(words[1]== "Reseptionist")
			{
				CurrentProfile.Role = Role.Receptionis;
				CurrentProfile.me = new User(words[9], words[0], words[2], words[3], words[4], words[5], words[6], words[7], words[8]);
				CurrentProfile.numbers = new List<Number>();
				CurrentProfile.snum = 0;
				CurrentProfile.bookings = new List<Booking>();
				CurrentProfile.stype = 0;
				CurrentProfile.updBook = false;
				CurrentProfile.types = new List<Type>();
				CurrentProfile.guests = new List<User>();
				CurrentProfile.updgue = false;
				CurrentProfile.sizegue = 0;
				CurrentProfile.settles = new List<Settling>();
				CurrentProfile.updSettle = false;
				CurrentProfile.sizeSettle = 0;
				GuestCommands.sendType(0);
				AllForms.receptionistMenu.Show();
				textBox1.Text = "";
				textBox2.Text = "";
				this.Hide();
			}
			if (words[1] == "Cleaner")
			{
				CurrentProfile.Role = Role.Cleaner;
				CurrentProfile.numbers = new List<Number>();
				CurrentProfile.stype = 0;
				CurrentProfile.types = new List<Type>();
				GuestCommands.sendType(0);
				AllForms.CleanerMenu.Show();
				textBox1.Text = "";
				textBox2.Text = "";
				this.Hide();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			AllForms.registration.Show();
			this.Hide();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar>='a'&&e.KeyChar<='z')|| (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar==8)
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
