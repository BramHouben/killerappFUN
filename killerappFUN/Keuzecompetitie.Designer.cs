namespace killerappFUN
{
    partial class Keuzecompetitie
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopscoorder = new System.Windows.Forms.Label();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.btnKeuze = new System.Windows.Forms.Button();
            this.teamToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topscoorder";
            // 
            // lblTopscoorder
            // 
            this.lblTopscoorder.AutoSize = true;
            this.lblTopscoorder.Location = new System.Drawing.Point(31, 61);
            this.lblTopscoorder.Name = "lblTopscoorder";
            this.lblTopscoorder.Size = new System.Drawing.Size(0, 13);
            this.lblTopscoorder.TabIndex = 1;
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(292, 54);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(116, 186);
            this.lbTeams.TabIndex = 2;
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(292, 33);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(70, 13);
            this.lblTeams.TabIndex = 3;
            this.lblTeams.Text = "Kies teaminfo";
            // 
            // btnKeuze
            // 
            this.btnKeuze.Location = new System.Drawing.Point(446, 54);
            this.btnKeuze.Name = "btnKeuze";
            this.btnKeuze.Size = new System.Drawing.Size(75, 23);
            this.btnKeuze.TabIndex = 4;
            this.btnKeuze.Text = "Kiezen";
            this.btnKeuze.UseVisualStyleBackColor = true;
            this.btnKeuze.Click += new System.EventHandler(this.btnKeuze_Click);
            // 
            // teamToevoegen
            // 
            this.teamToevoegen.Location = new System.Drawing.Point(34, 254);
            this.teamToevoegen.Name = "teamToevoegen";
            this.teamToevoegen.Size = new System.Drawing.Size(115, 23);
            this.teamToevoegen.TabIndex = 5;
            this.teamToevoegen.Text = "Team toevoegen";
            this.teamToevoegen.UseVisualStyleBackColor = true;
            this.teamToevoegen.Click += new System.EventHandler(this.teamToevoegen_Click);
            // 
            // Keuzecompetitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 291);
            this.Controls.Add(this.teamToevoegen);
            this.Controls.Add(this.btnKeuze);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.lblTopscoorder);
            this.Controls.Add(this.label1);
            this.Name = "Keuzecompetitie";
            this.Text = "Keuzecompetitie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopscoorder;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Button btnKeuze;
        private System.Windows.Forms.Button teamToevoegen;
    }
}