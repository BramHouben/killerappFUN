using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace killerappFUN
{
    internal class competitie
    {
        private Database db = new Database();
        private string Naam;
        private int Aantal;

        //private int Comp_id;
        private string Tpscoorder;

        public List<string> competities = new List<string>();/* { get; set; }*/
        private int gekozenid;

        public competitie()
        {
        }

        public competitie(string naam, int aantal, string tpscoorder)
        {
            this.Naam = naam;
            this.Aantal = aantal;
            this.Tpscoorder = tpscoorder;
        }

        public IEnumerable<string> krijgencomp()
        {
            using (MySqlConnection connection = new MySqlConnection())
            {
                db.OpenConn();

                try
                {
                    string query = "select competitie_naam from competitie";

                    DataTable tap = new DataTable();
                    new MySqlDataAdapter(query, db.connectiestring()).Fill(tap);
                    competities = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("competitie_naam")).ToList();
                }
                catch (Exception fout)
                {
                    Console.WriteLine(fout);
                }
                finally
                {
                    db.CloseConnection();
                }

                return competities;
            }
        }

        public int krijgID(string gekozen_item)
        {
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select competitie_id from competitie where competitie_naam = '" + gekozen_item + "' ", db.connectiestring());

                gekozenid = (int)cm5.ExecuteScalar();

                //return gekozenid;
                return gekozenid;
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }
            return gekozenid;
        }

        public bool checkcomp()
        {
            db.OpenConn();
            MySqlCommand checkvoorcomp = new MySqlCommand("select * from competitie where competitie_naam = '" + Naam + "' ", db.connectiestring());

            MySqlDataReader reader = checkvoorcomp.ExecuteReader();
            //int result = Convert.ToInt32(checkvoorcomp.ExecuteReader());
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return checktrainer();
        }

        public bool toevoegencomp()
        {
            db.OpenConn();
            var command = db.connectiestring().CreateCommand();
            command.Parameters.AddWithValue("@competitie_naam", Naam);
            command.Parameters.AddWithValue("@aantal_teams", Aantal);
            command.Parameters.AddWithValue("@competitie_topscorer", Tpscoorder);
            command.CommandText = "INSERT INTO competitie (competitie_id, competitie_naam, aantal_teams, competitie_topscorer ) VALUES (null, @competitie_naam, @aantal_teams, @competitie_topscorer)";
            bool result = checkcomp();
            if (result == false)
            {
                command.ExecuteNonQuery();
            }

            db.CloseConnection();
            return result;
        }
    }
}