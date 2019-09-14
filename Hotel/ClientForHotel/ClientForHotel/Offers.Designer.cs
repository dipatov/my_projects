namespace ClientForHotel
{
	partial class Offers
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Numb = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Floor,
            this.Type,
            this.Count});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 341);
			this.dataGridView1.TabIndex = 0;
			// 
			// Number
			// 
			this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Number.HeaderText = "Номер";
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			// 
			// Floor
			// 
			this.Floor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Floor.HeaderText = "Этаж";
			this.Floor.Name = "Floor";
			this.Floor.ReadOnly = true;
			// 
			// Type
			// 
			this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Type.HeaderText = "Тип";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			// 
			// Count
			// 
			this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Count.HeaderText = "Стоимость";
			this.Count.Name = "Count";
			this.Count.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(678, 375);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 50);
			this.button1.TabIndex = 1;
			this.button1.Text = "Информация о типах";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 392);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Введите номер";
			// 
			// Numb
			// 
			this.Numb.Location = new System.Drawing.Point(126, 392);
			this.Numb.Name = "Numb";
			this.Numb.Size = new System.Drawing.Size(100, 22);
			this.Numb.TabIndex = 3;
			this.Numb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numb_KeyPress);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(245, 387);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 33);
			this.button2.TabIndex = 4;
			this.button2.Text = "Забронировать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(547, 376);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 48);
			this.button3.TabIndex = 5;
			this.button3.Text = "В главное меню";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Offers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Numb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Offers";
			this.Text = " Предложения";
			this.Load += new System.EventHandler(this.Offers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Numb;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}