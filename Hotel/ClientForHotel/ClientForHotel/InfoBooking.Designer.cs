﻿namespace ClientForHotel
{
	partial class InfoBooking
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Guests = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SettleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AmountOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(327, 390);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "В главное меню";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number,
            this.Guests,
            this.SettleDate,
            this.AmountOfDays,
            this.Count});
			this.dataGridView1.Location = new System.Drawing.Point(12, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(766, 353);
			this.dataGridView1.TabIndex = 3;
			// 
			// Id
			// 
			this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Number
			// 
			this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Number.HeaderText = "Номер";
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			// 
			// Guests
			// 
			this.Guests.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Guests.HeaderText = "Проживающих";
			this.Guests.Name = "Guests";
			this.Guests.ReadOnly = true;
			// 
			// SettleDate
			// 
			this.SettleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SettleDate.HeaderText = "Дата заселения";
			this.SettleDate.Name = "SettleDate";
			this.SettleDate.ReadOnly = true;
			// 
			// AmountOfDays
			// 
			this.AmountOfDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AmountOfDays.HeaderText = "Дней проживания";
			this.AmountOfDays.Name = "AmountOfDays";
			this.AmountOfDays.ReadOnly = true;
			// 
			// Count
			// 
			this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Count.HeaderText = "Стоимость";
			this.Count.Name = "Count";
			this.Count.ReadOnly = true;
			// 
			// InfoBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "InfoBooking";
			this.Text = "Информация о бронях";
			this.Load += new System.EventHandler(this.InfoBooking_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Guests;
		private System.Windows.Forms.DataGridViewTextBoxColumn SettleDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfDays;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
	}
}