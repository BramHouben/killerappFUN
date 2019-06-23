using System;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class Beginscherm : Form
    {
        public Beginscherm()
        {
            InitializeComponent();
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            var newform = new Registreren();
            newform.Show();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            // Kijken of textboxes ingevuld zijn
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("gebruikersnaam mag niet leeg zijn!");
            }
            else if (string.IsNullOrWhiteSpace(tbWW.Text))
            {
                MessageBox.Show("wachtwoord mag niet leeg zijn!");
            }
            else
            {
                // Inlog check
                Database inlog = new Database();
                bool result = inlog.inloggen(tbEmail.Text, tbWW.Text);
                if (result == true)
                {
                    this.Hide();
                    competitieForm cp = new competitieForm();
                    cp.Show();
                }
                else
                {
                    MessageBox.Show("fout met inloggen!");
                    // Resetten textboxen
                    tbEmail.Clear();
                    tbWW.Clear();
                }
            }
        }

        private void Beginscherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}