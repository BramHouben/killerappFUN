namespace killerappFUN
{
    partial class keuzeteam
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
            this.lblteam_naam = new System.Windows.Forms.Label();
            this.lbspelers = new System.Windows.Forms.ListBox();
            this.lblspelers = new System.Windows.Forms.Label();
            this.btnziespeler = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblteam_naam
            // 
            this.lblteam_naam.AutoSize = true;
            this.lblteam_naam.Location = new System.Drawing.Point(13, 13);
            this.lblteam_naam.Name = "lblteam_naam";
            this.lblteam_naam.Size = new System.Drawing.Size(0, 13);
            this.lblteam_naam.TabIndex = 0;
            // 
            // lbspelers
            // 
            this.lbspelers.FormattingEnabled = true;
            this.lbspelers.Location = new System.Drawing.Point(274, 73);
            this.lbspelers.Name = "lbspelers";
            this.lbspelers.Size = new System.Drawing.Size(109, 251);
            this.lbspelers.TabIndex = 1;
            // 
            // lblspelers
            // 
            this.lblspelers.AutoSize = true;
            this.lblspelers.Location = new System.Drawing.Point(271, 33);
            this.lblspelers.Name = "lblspelers";
            this.lblspelers.Size = new System.Drawing.Size(42, 13);
            this.lblspelers.TabIndex = 2;
            this.lblspelers.Text = "Spelers";
            // 
            // btnziespeler
            // 
            this.btnziespeler.Location = new System.Drawing.Point(49, 300);
            this.btnziespeler.Name = "btnziespeler";
            this.btnziespeler.Size = new System.Drawing.Size(111, 23);
            this.btnziespeler.TabIndex = 3;
            this.btnziespeler.Text = "Speler Bekijken";
            this.btnziespeler.UseVisualStyleBackColor = true;
            this.btnziespeler.Click += new System.EventHandler(this.btnziespeler_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(49, 207);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(111, 23);
            this.btnToevoegen.TabIndex = 4;
            this.btnToevoegen.Text = "speler toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // keuzeteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 373);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnziespeler);
            this.Controls.Add(this.lblspelers);
            this.Controls.Add(this.lbspelers);
            this.Controls.Add(this.lblteam_naam);
            this.Name = "keuzeteam";
            this.Text = "keuzeteam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblteam_naam;
        private System.Windows.Forms.ListBox lbspelers;
        private System.Windows.Forms.Label lblspelers;
        private System.Windows.Forms.Button btnziespeler;
        private System.Windows.Forms.Button btnToevoegen;
    }
}