namespace ClientForHotel
{
	partial class Anketa
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
			this.tEmail = new System.Windows.Forms.TextBox();
			this.tPhone = new System.Windows.Forms.TextBox();
			this.tNumber = new System.Windows.Forms.TextBox();
			this.tmName = new System.Windows.Forms.TextBox();
			this.tlName = new System.Windows.Forms.TextBox();
			this.tName = new System.Windows.Forms.TextBox();
			this.tSeria = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tEmail
			// 
			this.tEmail.Location = new System.Drawing.Point(184, 230);
			this.tEmail.Name = "tEmail";
			this.tEmail.Size = new System.Drawing.Size(277, 22);
			this.tEmail.TabIndex = 37;
			// 
			// tPhone
			// 
			this.tPhone.Location = new System.Drawing.Point(184, 202);
			this.tPhone.Name = "tPhone";
			this.tPhone.Size = new System.Drawing.Size(277, 22);
			this.tPhone.TabIndex = 36;
			this.tPhone.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			this.tPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPhone_KeyPress);
			// 
			// tNumber
			// 
			this.tNumber.Location = new System.Drawing.Point(184, 174);
			this.tNumber.Name = "tNumber";
			this.tNumber.Size = new System.Drawing.Size(277, 22);
			this.tNumber.TabIndex = 35;
			this.tNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNumber_KeyPress);
			// 
			// tmName
			// 
			this.tmName.Location = new System.Drawing.Point(184, 118);
			this.tmName.Name = "tmName";
			this.tmName.Size = new System.Drawing.Size(277, 22);
			this.tmName.TabIndex = 34;
			this.tmName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tmName_KeyPress);
			// 
			// tlName
			// 
			this.tlName.Location = new System.Drawing.Point(184, 90);
			this.tlName.Name = "tlName";
			this.tlName.Size = new System.Drawing.Size(277, 22);
			this.tlName.TabIndex = 33;
			this.tlName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tlName_KeyPress);
			// 
			// tName
			// 
			this.tName.Location = new System.Drawing.Point(184, 62);
			this.tName.Name = "tName";
			this.tName.Size = new System.Drawing.Size(277, 22);
			this.tName.TabIndex = 32;
			this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
			this.tName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tName_KeyPress);
			// 
			// tSeria
			// 
			this.tSeria.Location = new System.Drawing.Point(184, 146);
			this.tSeria.Name = "tSeria";
			this.tSeria.Size = new System.Drawing.Size(277, 22);
			this.tSeria.TabIndex = 30;
			this.tSeria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSeria_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(127, 235);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 17);
			this.label8.TabIndex = 27;
			this.label8.Text = "E-mail:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(53, 210);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(125, 17);
			this.label7.TabIndex = 26;
			this.label7.Text = "Номер телефона:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(57, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 17);
			this.label6.TabIndex = 25;
			this.label6.Text = "Номер паспорта:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(59, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 17);
			this.label5.TabIndex = 24;
			this.label5.Text = "Серия паспорта:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(103, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 17);
			this.label4.TabIndex = 23;
			this.label4.Text = "Отчество:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(108, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 17);
			this.label3.TabIndex = 22;
			this.label3.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(139, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Имя:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 258);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 35);
			this.button1.TabIndex = 38;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
			// 
			// Anketa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 363);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tEmail);
			this.Controls.Add(this.tPhone);
			this.Controls.Add(this.tNumber);
			this.Controls.Add(this.tmName);
			this.Controls.Add(this.tlName);
			this.Controls.Add(this.tName);
			this.Controls.Add(this.tSeria);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Anketa";
			this.Text = "Anketa";
			this.Load += new System.EventHandler(this.Anketa_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tEmail;
		private System.Windows.Forms.TextBox tPhone;
		private System.Windows.Forms.TextBox tNumber;
		private System.Windows.Forms.TextBox tmName;
		private System.Windows.Forms.TextBox tlName;
		private System.Windows.Forms.TextBox tName;
		private System.Windows.Forms.TextBox tSeria;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}