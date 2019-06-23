using System;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class competitieForm : Form
    {
        private readonly competitie cmp = new competitie();

        public competitieForm()
        {
            InitializeComponent();

            krijgencomp();
        }

        private void krijgencomp()
        {
            LbCompetities.DataSource = cmp.krijgencomp();
        }

        private void btnUItlog_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Beginscherm newform = new Beginscherm();
            //newform.Show();
        }

        private void btnCompetitie_Click(object sender, EventArgs e)
        {
            string gekozen_item = LbCompetities.GetItemText(LbCompetities.SelectedValue);
            int id = cmp.krijgID(gekozen_item);
            Keuzecompetitie keuze = new Keuzecompetitie(id);
            keuze.Show();
        }

        private void BtncompToevoegen_Click(object sender, EventArgs e)
        {
            Tussencheck nieuwform = new Tussencheck();
            nieuwform.Show();
        }
    }
}