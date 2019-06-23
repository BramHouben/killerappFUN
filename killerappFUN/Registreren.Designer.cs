namespace killerappFUN
{
    partial class Registreren
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWW = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbWW = new System.Windows.Forms.TextBox();
            this.btnwwzien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(12, 161);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreren.TabIndex = 0;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(24, 53);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblWW
            // 
            this.lblWW.AutoSize = true;
            this.lblWW.Location = new System.Drawing.Point(24, 118);
            this.lblWW.Name = "lblWW";
            this.lblWW.Size = new System.Drawing.Size(71, 13);
            this.lblWW.TabIndex = 3;
            this.lblWW.Text = "Wachtwoord:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(118, 53);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(135, 20);
            this.tbNaam.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(118, 84);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(135, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // tbWW
            // 
            this.tbWW.Location = new System.Drawing.Point(118, 118);
            this.tbWW.Name = "tbWW";
            this.tbWW.Size = new System.Drawing.Size(135, 20);
            this.tbWW.TabIndex = 6;
            this.tbWW.UseSystemPasswordChar = true;
            // 
            // btnwwzien
            // 
            this.btnwwzien.Location = new System.Drawing.Point(178, 164);
            this.btnwwzien.Name = "btnwwzien";
            this.btnwwzien.Size = new System.Drawing.Size(75, 20);
            this.btnwwzien.TabIndex = 7;
            this.btnwwzien.Text = "ww zien";
            this.btnwwzien.UseVisualStyleBackColor = true;
            this.btnwwzien.Click += new System.EventHandler(this.btnwwzien_Click);
            // 
            // Registreren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(314, 205);
            this.Controls.Add(this.btnwwzien);
            this.Controls.Add(this.tbWW);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblWW);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnRegistreren);
            this.Name = "Registreren";
            this.Text = "Registreren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWW;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbWW;
        private System.Windows.Forms.Button btnwwzien;
    }
}