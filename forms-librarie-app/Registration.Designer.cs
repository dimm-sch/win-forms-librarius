namespace forms_librarie_app
{
	partial class Registration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxUserPassword = new System.Windows.Forms.TextBox();
			this.buttonSignUp = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxUserPasswordRepeated = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(65, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Înregistrare";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numele de utilizator";
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUserName.Location = new System.Drawing.Point(16, 156);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(268, 26);
			this.textBoxUserName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Parola";
			// 
			// textBoxUserPassword
			// 
			this.textBoxUserPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUserPassword.Location = new System.Drawing.Point(16, 239);
			this.textBoxUserPassword.Name = "textBoxUserPassword";
			this.textBoxUserPassword.Size = new System.Drawing.Size(268, 26);
			this.textBoxUserPassword.TabIndex = 5;
			this.textBoxUserPassword.UseSystemPasswordChar = true;
			// 
			// buttonSignUp
			// 
			this.buttonSignUp.BackColor = System.Drawing.Color.Brown;
			this.buttonSignUp.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSignUp.ForeColor = System.Drawing.Color.White;
			this.buttonSignUp.Location = new System.Drawing.Point(59, 389);
			this.buttonSignUp.Name = "buttonSignUp";
			this.buttonSignUp.Size = new System.Drawing.Size(177, 41);
			this.buttonSignUp.TabIndex = 8;
			this.buttonSignUp.Text = "Crează cont";
			this.buttonSignUp.UseVisualStyleBackColor = false;
			this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 281);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Parola repetat";
			// 
			// textBoxUserPasswordRepeated
			// 
			this.textBoxUserPasswordRepeated.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUserPasswordRepeated.Location = new System.Drawing.Point(16, 325);
			this.textBoxUserPasswordRepeated.Name = "textBoxUserPasswordRepeated";
			this.textBoxUserPasswordRepeated.Size = new System.Drawing.Size(268, 26);
			this.textBoxUserPasswordRepeated.TabIndex = 7;
			this.textBoxUserPasswordRepeated.UseSystemPasswordChar = true;
			// 
			// Registration
			// 
			this.AcceptButton = this.buttonSignUp;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(296, 466);
			this.Controls.Add(this.textBoxUserPasswordRepeated);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonSignUp);
			this.Controls.Add(this.textBoxUserPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Registration";
			this.Text = "Înregistrare";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxUserPassword;
		private System.Windows.Forms.Button buttonSignUp;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxUserPasswordRepeated;
	}
}