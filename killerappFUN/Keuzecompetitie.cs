//using killerappFUN.classes;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class Keuzecompetitie : Form
    {
        private team team = new team();
        private int gekregen_id;

        public Keuzecompetitie(int gekozen_item)
        {
            gekregen_id = gekozen_item;
            InitializeComponent();
            lbTeams.DataSource = team.krijgenTeams(gekregen_id);
            lblTopscoorder.Text = team.krijgenTopscoorder();
        }

        private void btnKeuze_Click(object sender, System.EventArgs e)
        {
            string gekozen_item = lbTeams.GetItemText(lbTeams.SelectedValue);
            int id = team.krijgIDteam(gekozen_item);
            keuzeteam keuze = new keuzeteam(id);
            keuze.Show();
        }

        private void teamToevoegen_Click(object sender, System.EventArgs e)
        {
            Tussencheck nieuwform = new Tussencheck(gekregen_id);
            nieuwform.Show();
        }
    }
}