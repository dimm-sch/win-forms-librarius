namespace forms_librarie_app
{
	partial class Authentification
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxUserPassword = new System.Windows.Forms.TextBox();
			this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxLoginType = new System.Windows.Forms.ComboBox();
			this.buttonLogIn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(61, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Autentificare";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numele de utilizator";
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUserName.Location = new System.Drawing.Point(17, 132);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(268, 26);
			this.textBoxUserName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Parola";
			// 
			// textBoxUserPassword
			// 
			this.textBoxUserPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUserPassword.Location = new System.Drawing.Point(17, 211);
			this.textBoxUserPassword.Name = "textBoxUserPassword";
			this.textBoxUserPassword.Size = new System.Drawing.Size(268, 26);
			this.textBoxUserPassword.TabIndex = 4;
			this.textBoxUserPassword.UseSystemPasswordChar = true;
			// 
			// linkLabelSignUp
			// 
			this.linkLabelSignUp.AutoSize = true;
			this.linkLabelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelSignUp.LinkColor = System.Drawing.Color.White;
			this.linkLabelSignUp.Location = new System.Drawing.Point(12, 421);
			this.linkLabelSignUp.Name = "linkLabelSignUp";
			this.linkLabelSignUp.Size = new System.Drawing.Size(166, 25);
			this.linkLabelSignUp.TabIndex = 8;
			this.linkLabelSignUp.TabStop = true;
			this.linkLabelSignUp.Text = "Creare cont nou";
			this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tipul contului";
			// 
			// comboBoxLoginType
			// 
			this.comboBoxLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLoginType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxLoginType.FormattingEnabled = true;
			this.comboBoxLoginType.Items.AddRange(new object[] {
            "Client",
            "Manager"});
			this.comboBoxLoginType.Location = new System.Drawing.Point(17, 283);
			this.comboBoxLoginType.Name = "comboBoxLoginType";
			this.comboBoxLoginType.Size = new System.Drawing.Size(135, 30);
			this.comboBoxLoginType.TabIndex = 6;
			// 
			// buttonLogIn
			// 
			this.buttonLogIn.BackColor = System.Drawing.Color.Brown;
			this.buttonLogIn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogIn.ForeColor = System.Drawing.Color.White;
			this.buttonLogIn.Location = new System.Drawing.Point(60, 343);
			this.buttonLogIn.Name = "buttonLogIn";
			this.buttonLogIn.Size = new System.Drawing.Size(177, 41);
			this.buttonLogIn.TabIndex = 7;
			this.buttonLogIn.Text = "Log In";
			this.buttonLogIn.UseVisualStyleBackColor = false;
			this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
			// 
			// Authentification
			// 
			this.AcceptButton = this.buttonLogIn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(297, 465);
			this.Controls.Add(this.buttonLogIn);
			this.Controls.Add(this.comboBoxLoginType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.linkLabelSignUp);
			this.Controls.Add(this.textBoxUserPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Authentification";
			this.Text = "Autentificare";
			this.Load += new System.EventHandler(this.Authentification_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxUserPassword;
		private System.Windows.Forms.LinkLabel linkLabelSignUp;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxLoginType;
		private System.Windows.Forms.Button buttonLogIn;
	}
}