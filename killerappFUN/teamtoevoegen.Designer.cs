namespace killerappFUN
{
    partial class teamtoevoegen
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
            this.numPlek = new System.Windows.Forms.NumericUpDown();
            this.btnInvoegen = new System.Windows.Forms.Button();
            this.tbtopscoorder = new System.Windows.Forms.TextBox();
            this.tbnaamTeam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlek)).BeginInit();
            this.SuspendLayout();
            // 
            // numPlek
            // 
            this.numPlek.Location = new System.Drawing.Point(112, 83);
            this.numPlek.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPlek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPlek.Name = "numPlek";
            this.numPlek.Size = new System.Drawing.Size(100, 20);
            this.numPlek.TabIndex = 16;
            this.numPlek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInvoegen
            // 
            this.btnInvoegen.Location = new System.Drawing.Point(112, 159);
            this.btnInvoegen.Name = "btnInvoegen";
            this.btnInvoegen.Size = new System.Drawing.Size(100, 23);
            this.btnInvoegen.TabIndex = 15;
            this.btnInvoegen.Text = "Invoegen";
            this.btnInvoegen.UseVisualStyleBackColor = true;
            this.btnInvoegen.Click += new System.EventHandler(this.btnInvoegen_Click);
            // 
            // tbtopscoorder
            // 
            this.tbtopscoorder.Location = new System.Drawing.Point(112, 107);
            this.tbtopscoorder.Name = "tbtopscoorder";
            this.tbtopscoorder.Size = new System.Drawing.Size(100, 20);
            this.tbtopscoorder.TabIndex = 14;
            // 
            // tbnaamTeam
            // 
            this.tbnaamTeam.Location = new System.Drawing.Point(112, 53);
            this.tbnaamTeam.Name = "tbnaamTeam";
            this.tbnaamTeam.Size = new System.Drawing.Size(100, 20);
            this.tbnaamTeam.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Topscoorder Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Huidige plek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Team toevoegen";
            // 
            // teamtoevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.numPlek);
            this.Controls.Add(this.btnInvoegen);
            this.Controls.Add(this.tbtopscoorder);
            this.Controls.Add(this.tbnaamTeam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "teamtoevoegen";
            this.Text = "teamtoevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.numPlek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPlek;
        private System.Windows.Forms.Button btnInvoegen;
        private System.Windows.Forms.TextBox tbtopscoorder;
        private System.Windows.Forms.TextBox tbnaamTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}