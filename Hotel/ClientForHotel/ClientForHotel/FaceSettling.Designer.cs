namespace ClientForHotel
{
	partial class FaceSettling
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
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.number = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.guests = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SettleDate = new System.Windows.Forms.DateTimePicker();
			this.UnsettleDate = new System.Windows.Forms.DateTimePicker();
			this.Id = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(262, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 48);
			this.button1.TabIndex = 31;
			this.button1.Text = "В главное меню";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(260, 224);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(127, 46);
			this.button3.TabIndex = 30;
			this.button3.Text = "Заселить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(180, 173);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 17);
			this.label8.TabIndex = 29;
			this.label8.Text = "Номер";
			// 
			// number
			// 
			this.number.Location = new System.Drawing.Point(247, 168);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(159, 22);
			this.number.TabIndex = 27;
			this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(50, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(181, 17);
			this.label6.TabIndex = 24;
			this.label6.Text = "Количество проживающих";
			// 
			// guests
			// 
			this.guests.Location = new System.Drawing.Point(247, 142);
			this.guests.Name = "guests";
			this.guests.Size = new System.Drawing.Size(159, 22);
			this.guests.TabIndex = 20;
			this.guests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guests_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "Дата выселения";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(115, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Дата заселения";
			// 
			// SettleDate
			// 
			this.SettleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.SettleDate.Location = new System.Drawing.Point(247, 87);
			this.SettleDate.MinDate = new System.DateTime(2019, 5, 25, 0, 0, 0, 0);
			this.SettleDate.Name = "SettleDate";
			this.SettleDate.Size = new System.Drawing.Size(159, 22);
			this.SettleDate.TabIndex = 25;
			this.SettleDate.Value = new System.DateTime(2019, 5, 25, 18, 24, 21, 0);
			// 
			// UnsettleDate
			// 
			this.UnsettleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.UnsettleDate.Location = new System.Drawing.Point(247, 115);
			this.UnsettleDate.MinDate = new System.DateTime(2019, 5, 25, 0, 0, 0, 0);
			this.UnsettleDate.Name = "UnsettleDate";
			this.UnsettleDate.Size = new System.Drawing.Size(159, 22);
			this.UnsettleDate.TabIndex = 32;
			this.UnsettleDate.Value = new System.DateTime(2019, 5, 25, 18, 24, 21, 0);
			// 
			// Id
			// 
			this.Id.Location = new System.Drawing.Point(247, 61);
			this.Id.Name = "Id";
			this.Id.Size = new System.Drawing.Size(159, 22);
			this.Id.TabIndex = 33;
			this.Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(212, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 17);
			this.label3.TabIndex = 34;
			this.label3.Text = "Id";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(260, 276);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 49);
			this.button2.TabIndex = 35;
			this.button2.Text = "Информация о гостях";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FaceSettling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Id);
			this.Controls.Add(this.UnsettleDate);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.number);
			this.Controls.Add(this.SettleDate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.guests);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FaceSettling";
			this.Text = "Заселение напрямую";
			this.Load += new System.EventHandler(this.FaceSettling_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox number;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox guests;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker SettleDate;
		private System.Windows.Forms.DateTimePicker UnsettleDate;
		private System.Windows.Forms.TextBox Id;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
	}
}