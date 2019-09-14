namespace ClientForHotel
{
	partial class ChangePass
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
			this.oldPassword = new System.Windows.Forms.TextBox();
			this.newPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// oldPassword
			// 
			this.oldPassword.Location = new System.Drawing.Point(177, 48);
			this.oldPassword.Name = "oldPassword";
			this.oldPassword.Size = new System.Drawing.Size(156, 22);
			this.oldPassword.TabIndex = 0;
			this.oldPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldPassword_KeyPress);
			// 
			// newPassword
			// 
			this.newPassword.Location = new System.Drawing.Point(177, 76);
			this.newPassword.Name = "newPassword";
			this.newPassword.Size = new System.Drawing.Size(156, 22);
			this.newPassword.TabIndex = 1;
			this.newPassword.TextChanged += new System.EventHandler(this.newPassword_TextChanged);
			this.newPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPassword_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Старый пароль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(69, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Новый пароль";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 119);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 33);
			this.button1.TabIndex = 4;
			this.button1.Text = "Изменить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ChangePass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 185);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.newPassword);
			this.Controls.Add(this.oldPassword);
			this.Name = "ChangePass";
			this.Text = "Изменить пароль";
			this.Load += new System.EventHandler(this.ChangePass_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox oldPassword;
		private System.Windows.Forms.TextBox newPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}