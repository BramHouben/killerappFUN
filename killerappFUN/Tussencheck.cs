using System;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class Tussencheck : Form
    {
        private int gekregen_id;

        public Tussencheck()
        {
        }

        public Tussencheck(int gekregen_id)
        {
            this.gekregen_id = gekregen_id;
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (tbInvoer.Text == "comptoevoegen")
            {
                this.Close();
                competitietoevoegen nieuwform = new competitietoevoegen();
                nieuwform.Show();
            }
            else if (tbInvoer.Text == "teamtoevoegen")
            {
                this.Close();
                teamtoevoegen nieuwform = new teamtoevoegen(gekregen_id);
                nieuwform.Show();
            }
            else if (tbInvoer.Text == "spelertoevoegen")
            {
                this.Close();
                spelertoevoegen nieuwform = new spelertoevoegen(gekregen_id);
                nieuwform.Show();
            }
            else
            {
                MessageBox.Show("Helaas!");
                this.Close();
            }
        }
    }
}