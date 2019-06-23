using System;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class spelertoevoegen : Form
    {
        private readonly int huidigeteam;

        public spelertoevoegen(int gekregen_id)
        {
            huidigeteam = gekregen_id;
            InitializeComponent();
        }

        private void btnInvoegen_Click(object sender, EventArgs e)
        {
            speler speler = new speler(tbnaamTeam.Text, (double)numlengte.Value, (int)numWaarde.Value, huidigeteam);
            // Tostring Methode
            Console.WriteLine(speler);
            //comp.toevoegencomp();
            bool result = speler.toevoegenspeler();

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