namespace killerappFUN
{
    partial class competitieForm
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
            this.LbCompetities = new System.Windows.Forms.ListBox();
            this.btnCompetitie = new System.Windows.Forms.Button();
            this.btnUItlog = new System.Windows.Forms.Button();
            this.BtncompToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbCompetities
            // 
            this.LbCompetities.FormattingEnabled = true;
            this.LbCompetities.Location = new System.Drawing.Point(35, 45);
            this.LbCompetities.Name = "LbCompetities";
            this.LbCompetities.Size = new System.Drawing.Size(99, 186);
            this.LbCompetities.TabIndex = 0;
            // 
            // btnCompetitie
            // 
            this.btnCompetitie.Location = new System.Drawing.Point(301, 45);
            this.btnCompetitie.Name = "btnCompetitie";
            this.btnCompetitie.Size = new System.Drawing.Size(183, 53);
            this.btnCompetitie.TabIndex = 1;
            this.btnCompetitie.Text = "Kies";
            this.btnCompetitie.UseVisualStyleBackColor = true;
            this.btnCompetitie.Click += new System.EventHandler(this.btnCompetitie_Click);
            // 
            // btnUItlog
            // 
            this.btnUItlog.Location = new System.Drawing.Point(409, 13);
            this.btnUItlog.Name = "btnUItlog";
            this.btnUItlog.Size = new System.Drawing.Size(75, 23);
            this.btnUItlog.TabIndex = 2;
            this.btnUItlog.Text = "Uitloggen";
            this.btnUItlog.UseVisualStyleBackColor = true;
            this.btnUItlog.Click += new System.EventHandler(this.btnUItlog_Click);
            // 
            // BtncompToevoegen
            // 
            this.BtncompToevoegen.Location = new System.Drawing.Point(301, 208);
            this.BtncompToevoegen.Name = "BtncompToevoegen";
            this.BtncompToevoegen.Size = new System.Drawing.Size(183, 23);
            this.BtncompToevoegen.TabIndex = 3;
            this.BtncompToevoegen.Text = "Competitie toevoegen";
            this.BtncompToevoegen.UseVisualStyleBackColor = true;
            this.BtncompToevoegen.Click += new System.EventHandler(this.BtncompToevoegen_Click);
            // 
            // competitieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(540, 280);
            this.Controls.Add(this.BtncompToevoegen);
            this.Controls.Add(this.btnUItlog);
            this.Controls.Add(this.btnCompetitie);
            this.Controls.Add(this.LbCompetities);
            this.Name = "competitieForm";
            this.Text = "competitieForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbCompetities;
        private System.Windows.Forms.Button btnCompetitie;
        private System.Windows.Forms.Button btnUItlog;
        private System.Windows.Forms.Button BtncompToevoegen;
    }
}