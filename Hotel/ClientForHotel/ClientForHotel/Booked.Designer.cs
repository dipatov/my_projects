namespace ClientForHotel
{
	partial class Booked
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.amountDays = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.guests = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dateT = new System.Windows.Forms.DateTimePicker();
			this.maxim = new System.Windows.Forms.TextBox();
			this.minim = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// amountDays
			// 
			this.amountDays.Location = new System.Drawing.Point(236, 121);
			this.amountDays.Name = "amountDays";
			this.amountDays.Size = new System.Drawing.Size(159, 22);
			this.amountDays.TabIndex = 1;
			this.amountDays.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.amountDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountDays_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(104, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Дата заселения";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Количество дней проживания";
			// 
			// guests
			// 
			this.guests.Location = new System.Drawing.Point(236, 149);
			this.guests.Name = "guests";
			this.guests.Size = new System.Drawing.Size(159, 22);
			this.guests.TabIndex = 4;
			this.guests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guests_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(401, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(401, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "*";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(401, 154);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(181, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Количество проживающих";
			// 
			// dateT
			// 
			this.dateT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateT.Location = new System.Drawing.Point(236, 96);
			this.dateT.MinDate = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
			this.dateT.Name = "dateT";
			this.dateT.Size = new System.Drawing.Size(159, 22);
			this.dateT.TabIndex = 9;
			// 
			// maxim
			// 
			this.maxim.Location = new System.Drawing.Point(236, 205);
			this.maxim.Name = "maxim";
			this.maxim.Size = new System.Drawing.Size(159, 22);
			this.maxim.TabIndex = 10;
			this.maxim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxim_KeyPress);
			// 
			// minim
			// 
			this.minim.Location = new System.Drawing.Point(236, 177);
			this.minim.Name = "minim";
			this.minim.Size = new System.Drawing.Size(159, 22);
			this.minim.TabIndex = 11;
			this.minim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minim_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(79, 210);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Максимальная цена";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(85, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 17);
			this.label8.TabIndex = 13;
			this.label8.Text = "Минимальная цена";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(249, 233);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 46);
			this.button1.TabIndex = 14;
			this.button1.Text = "Подобрать предложения";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(251, 352);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 48);
			this.button2.TabIndex = 15;
			this.button2.Text = "В главное меню";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Booked
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 412);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.minim);
			this.Controls.Add(this.maxim);
			this.Controls.Add(this.dateT);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.guests);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.amountDays);
			this.Name = "Booked";
			this.Text = " Бронирование";
			this.Load += new System.EventHandler(this.Booked_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox amountDays;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox guests;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateT;
		private System.Windows.Forms.TextBox maxim;
		private System.Windows.Forms.TextBox minim;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}