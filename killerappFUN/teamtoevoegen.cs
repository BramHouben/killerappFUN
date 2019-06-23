using System;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class teamtoevoegen : Form
    {
        private readonly int huidigecomp;

        public teamtoevoegen(int gekregen_id)
        {
            huidigecomp = gekregen_id;
            InitializeComponent();
        }

        private void btnInvoegen_Click(object sender, EventArgs e)
        {
            team team = new team(tbnaamTeam.Text, tbtopscoorder.Text, (int)numPlek.Value, huidigecomp);
            // Tostring Methode
            Console.WriteLine(team.ToString());
            //comp.toevoegencomp();
            bool result = team.toevoegenteam();

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