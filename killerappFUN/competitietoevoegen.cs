using System;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class competitietoevoegen : Form
    {
        public competitietoevoegen()
        {
            InitializeComponent();
        }

        private void btnInvoegen_Click(object sender, EventArgs e)
        {
            competitie comp = new competitie(tbnaam.Text, (int)numAantal.Value, tbtopscoorder.Text);

            //comp.toevoegencomp();
            bool result = comp.toevoegencomp();

            if (result == true)
            {
                MessageBox.Show("niet ingevoegd");
                this.Close();
            }
            else
            {
                MessageBox.Show("wel ingevoegd!");
                this.Close();
            }
        }
    }
}