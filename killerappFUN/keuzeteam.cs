using System;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class keuzeteam : Form
    {
        private readonly team team = new team();

        private readonly int gekregen_id_team;

        public keuzeteam(int id)
        {
            gekregen_id_team = id;
            InitializeComponent();

            lbspelers.DataSource = team.krijgenSpelers(gekregen_id_team);
            lblteam_naam.Text = team.krijgenteamnaam(gekregen_id_team);
        }

        private void btnziespeler_Click(object sender, EventArgs e)
        {
            speler speler2 = new speler();
            Console.WriteLine(speler2);
            string value = lbspelers.GetItemText(lbspelers.SelectedValue);
            speler2.krijginfo(value);
            string naam = speler2.krijginfonaam();
            double lengte = speler2.krijginfolengte();
            int waarde = speler2.krijginfowaarde();
            MessageBox.Show(speler2.ToString());
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Tussencheck nieuwform = new Tussencheck(gekregen_id_team);
            nieuwform.Show();
        }
    }
}