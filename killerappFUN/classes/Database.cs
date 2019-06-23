using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace killerappFUN
{
    internal class Database
    {
        // Alle waardes declareren
        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string Naam;
        private string Email;
        private string Wachtwoord;
        private string WwHash;

        public void db()
        {
            server = "localhost";
            database = "funapp";
            uid = "root";
            password = string.Empty;

            string connectionString = "SERVER=" + server + ";" + "DATABASE = " + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // voor het inloggen
        public Database()
        {
        }

        public Database(string email, string wachtwoord, string naam)
        {
            Naam = naam;
            Email = email;
            Wachtwoord = wachtwoord;
        }

        // Snel de connectie string krijgen
        public MySqlConnection connectiestring()
        {
            return connection;
        }

        public bool OpenConn()
        {
            db();
            try
            {
                connection.Open();
                Console.WriteLine("Connectie is open");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            db();
            try
            {
                connection.Close();
                Console.WriteLine("Connectie is dicht");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool registreren()
        {
            OpenConn();
            WwHash = BCrypt.Net.BCrypt.HashPassword(Wachtwoord, BCrypt.Net.BCrypt.GenerateSalt(12));
            // Deze query zorgt ervoor dat je gegens invoert in de database
            string query = "INSERT INTO user (gebruikers_email,gebruikers_naam, gebruikers_ww) VALUES (@gebruikers_email,@gebruikers_naam,@gebruikers_ww)";

            using (MySqlCommand registratie = new MySqlCommand(query, connection))
            {
                try
                {
                    registratie.Parameters.AddWithValue("@gebruikers_email", Email);
                    registratie.Parameters.AddWithValue("@gebruikers_ww", WwHash);
                    registratie.Parameters.AddWithValue("@gebruikers_naam", Naam);

                    // checken of email al bestaat
                    MySqlCommand cmd = new MySqlCommand("Select count(*) from user where gebruikers_email= @gebruikers_email", connection);
                    cmd.Parameters.AddWithValue("@gebruikers_email", Email);
                    var gbnaamexist = cmd.ExecuteScalar();
                    int test = Convert.ToInt32(gbnaamexist);
                    if (test >= 1)
                    {
                        return false;
                    }
                    else
                    {
                        int result = registratie.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                catch (Exception foutregistreren)
                {
                    Console.WriteLine(foutregistreren.Message);
                    return false;
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public bool inloggen(string gbMail, string wachtwoord)
        {
            try
            {
                OpenConn();
                string Username = "Select gebruikers_ww from user where gebruikers_email='" + gbMail + "'";

                MySqlCommand inloggen = new MySqlCommand(Username, connectiestring());

                var hashie = inloggen.ExecuteScalar().ToString();

                bool controle = BCrypt.Net.BCrypt.CheckPassword(wachtwoord, hashie);
                if (controle == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception foutinloggen)
            {
                Console.WriteLine(foutinloggen.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}