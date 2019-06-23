using System;
using System.Linq;
using System.Windows.Forms;

namespace killerappFUN
{
    public partial class Registreren : Form
    {
        public Registreren()
        {
            InitializeComponent();
        }

        private void btnwwzien_Click(object sender, EventArgs e)
        {
            tbWW.UseSystemPasswordChar = false;
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            // Controle of de textboxes leeg zijn
            var emptyTextboxes = from tb in this.Controls.OfType<TextBox>()
                                 where string.IsNullOrEmpty(tb.Text)
                                 select tb;
            if (emptyTextboxes.Any())
            {
                MessageBox.Show("vul alle velden in!");
            }
            else
            {
                Database user = new Database(tbEmail.Text, tbWW.Text, tbNaam.Text);
                bool result = user.registreren();
                if (result == true)
                {
                    MessageBox.Show("Account aangemaakt!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("fout met registreren!");
                }
            }
        }
    }
}