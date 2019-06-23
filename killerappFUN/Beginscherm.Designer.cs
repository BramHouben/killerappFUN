namespace killerappFUN
{
    partial class Beginscherm
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
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.tbWW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(257, 180);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreren.TabIndex = 2;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(36, 180);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(75, 23);
            this.btnInloggen.TabIndex = 3;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(142, 62);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(145, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(33, 109);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lblWachtwoord.TabIndex = 6;
            this.lblWachtwoord.Text = "Wachtwoord";
            // 
            // tbWW
            // 
            this.tbWW.Location = new System.Drawing.Point(142, 106);
            this.tbWW.Name = "tbWW";
            this.tbWW.Size = new System.Drawing.Size(145, 20);
            this.tbWW.TabIndex = 7;
            this.tbWW.UseSystemPasswordChar = true;
            // 
            // Beginscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 216);
            this.Controls.Add(this.tbWW);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.btnRegistreren);
            this.Name = "Beginscherm";
            this.Text = "BeginInlog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Beginscherm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.TextBox tbWW;
    }
}

