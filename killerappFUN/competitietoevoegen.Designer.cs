namespace killerappFUN
{
    partial class competitietoevoegen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnaam = new System.Windows.Forms.TextBox();
            this.tbtopscoorder = new System.Windows.Forms.TextBox();
            this.btnInvoegen = new System.Windows.Forms.Button();
            this.numAantal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competitie toevoegen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aantal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Topscoorder";
            // 
            // tbnaam
            // 
            this.tbnaam.Location = new System.Drawing.Point(98, 44);
            this.tbnaam.Name = "tbnaam";
            this.tbnaam.Size = new System.Drawing.Size(100, 20);
            this.tbnaam.TabIndex = 4;
            // 
            // tbtopscoorder
            // 
            this.tbtopscoorder.Location = new System.Drawing.Point(98, 98);
            this.tbtopscoorder.Name = "tbtopscoorder";
            this.tbtopscoorder.Size = new System.Drawing.Size(100, 20);
            this.tbtopscoorder.TabIndex = 6;
            // 
            // btnInvoegen
            // 
            this.btnInvoegen.Location = new System.Drawing.Point(98, 138);
            this.btnInvoegen.Name = "btnInvoegen";
            this.btnInvoegen.Size = new System.Drawing.Size(100, 23);
            this.btnInvoegen.TabIndex = 7;
            this.btnInvoegen.Text = "Invoegen";
            this.btnInvoegen.UseVisualStyleBackColor = true;
            this.btnInvoegen.Click += new System.EventHandler(this.btnInvoegen_Click);
            // 
            // numAantal
            // 
            this.numAantal.Location = new System.Drawing.Point(98, 74);
            this.numAantal.Name = "numAantal";
            this.numAantal.Size = new System.Drawing.Size(100, 20);
            this.numAantal.TabIndex = 8;
            // 
            // competitietoevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 192);
            this.Controls.Add(this.numAantal);
            this.Controls.Add(this.btnInvoegen);
            this.Controls.Add(this.tbtopscoorder);
            this.Controls.Add(this.tbnaam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "competitietoevoegen";
            this.Text = "competitietoevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbnaam;
        private System.Windows.Forms.TextBox tbtopscoorder;
        private System.Windows.Forms.Button btnInvoegen;
        private System.Windows.Forms.NumericUpDown numAantal;
    }
}