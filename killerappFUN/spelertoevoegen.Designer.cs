namespace killerappFUN
{
    partial class spelertoevoegen
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
            this.numlengte = new System.Windows.Forms.NumericUpDown();
            this.btnInvoegen = new System.Windows.Forms.Button();
            this.tbnaamTeam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWaarde = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numlengte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaarde)).BeginInit();
            this.SuspendLayout();
            // 
            // numlengte
            // 
            this.numlengte.DecimalPlaces = 2;
            this.numlengte.Location = new System.Drawing.Point(115, 85);
            this.numlengte.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numlengte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numlengte.Name = "numlengte";
            this.numlengte.Size = new System.Drawing.Size(100, 20);
            this.numlengte.TabIndex = 24;
            this.numlengte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInvoegen
            // 
            this.btnInvoegen.Location = new System.Drawing.Point(115, 204);
            this.btnInvoegen.Name = "btnInvoegen";
            this.btnInvoegen.Size = new System.Drawing.Size(100, 23);
            this.btnInvoegen.TabIndex = 23;
            this.btnInvoegen.Text = "Invoegen";
            this.btnInvoegen.UseVisualStyleBackColor = true;
            this.btnInvoegen.Click += new System.EventHandler(this.btnInvoegen_Click);
            // 
            // tbnaamTeam
            // 
            this.tbnaamTeam.Location = new System.Drawing.Point(115, 55);
            this.tbnaamTeam.Name = "tbnaamTeam";
            this.tbnaamTeam.Size = new System.Drawing.Size(100, 20);
            this.tbnaamTeam.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "waarde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lengte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "speler toevoegen";
            // 
            // numWaarde
            // 
            this.numWaarde.Location = new System.Drawing.Point(115, 112);
            this.numWaarde.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numWaarde.Name = "numWaarde";
            this.numWaarde.Size = new System.Drawing.Size(100, 20);
            this.numWaarde.TabIndex = 25;
            // 
            // spelertoevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 248);
            this.Controls.Add(this.numWaarde);
            this.Controls.Add(this.numlengte);
            this.Controls.Add(this.btnInvoegen);
            this.Controls.Add(this.tbnaamTeam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "spelertoevoegen";
            this.Text = "spelertoevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.numlengte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaarde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numlengte;
        private System.Windows.Forms.Button btnInvoegen;
        private System.Windows.Forms.TextBox tbnaamTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numWaarde;
    }
}