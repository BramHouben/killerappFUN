using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace killerappFUN
{
    internal class team
    {
        private Database db = new Database();
        public List<string> teams = new List<string>();
        public List<string> spelers = new List<string>();
        private string Topscoorder;
        private int Gekozen_item;

        private int team_id;
        private string Team_naam;
        private string Top_scoorder;
        private int Huidige_plek;
        private int Comp_id;

        public team()
        {
        }

        public team(string team_naam, string top_scoorder, int huidige_plek, int comp_id)
        {
            this.Team_naam = team_naam;
            this.Top_scoorder = top_scoorder;
            this.Huidige_plek = huidige_plek;
            this.Comp_id = comp_id;
        }

        public IEnumerable<string> krijgenTeams(int gekozen_item)
        {
            this.Gekozen_item = gekozen_item;
            using (MySqlConnection connection = new MySqlConnection())
            {
                db.OpenConn();

                try
                {
                    string query = "select team_naam from team where competitie_id = " + gekozen_item + "";

                    DataTable tap = new DataTable();
                    new MySqlDataAdapter(query, db.connectiestring()).Fill(tap);
                    teams = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("team_naam")).ToList();
                    if (teams.Contains("Arsenal"))
                    {
                        Console.WriteLine("hey arsenal is mijn favoriete team!");
                    }
                }
                catch (Exception fout)
                {
                    Console.WriteLine(fout);
                }
                finally
                {
                    db.CloseConnection();
                }

                return teams;
            }
        }

        public string krijgenTopscoorder()
        {
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select competitie_topscorer from competitie where competitie_id = '" + Gekozen_item + "' ", db.connectiestring());

                Topscoorder = (string)cm5.ExecuteScalar();
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }
            return Topscoorder;
        }

        public bool checkteam()
        {
            db.OpenConn();
            MySqlCommand checkvoorteam = new MySqlCommand("select * from team where team_naam = '" + Team_naam + "' ", db.connectiestring());

            MySqlDataReader reader = checkvoorteam.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return checkdubbleplek();
            }
        }

        public bool checkdubbleplek()
        {
            db.OpenConn();
            MySqlCommand checkvoordubbel = new MySqlCommand("SELECT team_naam, huidige_plek,team.competitie_id FROM team INNER JOIN competitie ON team.competitie_id = competitie.competitie_id WHERE huidige_plek = " + Huidige_plek + " or team_naam='" + Team_naam + " and competitie_id = " + Comp_id + "' ", db.connectiestring());
            MySqlDataReader reader = checkvoordubbel.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool toevoegenteam()
        {
            db.OpenConn();
            var command = db.connectiestring().CreateCommand();
            command.Parameters.AddWithValue("@team_naam", Team_naam);
            command.Parameters.AddWithValue("@huidige_plek", Huidige_plek);
            command.Parameters.AddWithValue("@top_scorer_team", Top_scoorder);
            command.Parameters.AddWithValue("@Comp_id", Comp_id);
            command.CommandText = "INSERT INTO team (competitie_id, team_naam, huidige_plek, top_scorer_team ) VALUES (@Comp_id, @team_naam, @huidige_plek, @top_scorer_team)";
            bool result = checkteam();
            if (result == false)
            {
                command.ExecuteNonQuery();
            }

            db.CloseConnection();
            return result;
        }

        public int krijgIDteam(string gekozen_item)
        {
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select team_id from team where team_naam = '" + gekozen_item + "' ", db.connectiestring());

                team_id = (int)cm5.ExecuteScalar();

                //return gekozenid;
                return team_id;
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }
            return team_id;
        }

        public IEnumerable<string> krijgenSpelers(int gekozen_item)
        {
            team_id = gekozen_item;
            using (MySqlConnection connection = new MySqlConnection())
            {
                db.OpenConn();

                try
                {
                    string query = "select speler_naam from speler where team_id = " + team_id + "";

                    DataTable tap = new DataTable();
                    new MySqlDataAdapter(query, db.connectiestring()).Fill(tap);
                    spelers = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("speler_naam")).ToList();

                    int i = spelers.IndexOf("laca");
                    if (i >= 0)
                        Console.WriteLine("Lacazette staat op index " + i);
                }
                catch (Exception fout)
                {
                    Console.WriteLine(fout);
                }
                finally
                {
                    db.CloseConnection();
                }

                return spelers;
            }
        }

        public string krijgenteamnaam(int team_id)
        {
            this.team_id = team_id;
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select team_naam from team where team_id = '" + team_id + "' ", db.connectiestring());

                Team_naam = (string)cm5.ExecuteScalar();
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }

            return Team_naam;
        }

        public override string ToString()
        {
            string info = team_id.ToString() + " " + Team_naam + " " + Top_scoorder + " " + Huidige_plek.ToString() + " " + Comp_id.ToString();
            Console.WriteLine(info);
            return info;
        }
    }
}