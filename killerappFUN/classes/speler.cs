using MySql.Data.MySqlClient;
using System;

namespace killerappFUN
{
    internal class speler
    {
        private Database db = new Database();
        private string speler_naam;
        private double lengte;
        private int waarde;
        private int speler_id;
        private int team_id;

        public speler()
        {
        }

        public speler(string speler_naam, double lengte, int waarde, int id)
        {
            this.speler_naam = speler_naam;
            this.lengte = lengte;
            this.waarde = waarde;
            this.team_id = id;
        }

        public int krijginfo(string naam)
        {
            this.speler_naam = naam;
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select speler_id from speler where speler_naam = '" + speler_naam + "' ", db.connectiestring());

                speler_id = (int)cm5.ExecuteScalar();

                //return gekozenid;
                return speler_id;
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }

            return speler_id;
        }

        public double krijginfolengte()
        {
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select speler_lengte from speler where speler_id = '" + speler_id + "' ", db.connectiestring());

                lengte = (double)cm5.ExecuteScalar();

                //return gekozenid;
                return lengte;
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }

            return lengte;
        }

        public int krijginfowaarde()
        {
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select speler_transferwaarde from speler where speler_id = '" + speler_id + "' ", db.connectiestring());

                waarde = (int)cm5.ExecuteScalar();

                //return gekozenid;
                return waarde;
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }

            return waarde;
        }

        public string krijginfonaam()
        {
            try
            {
                db.OpenConn();
                MySqlCommand cm5 = new MySqlCommand(
                    "select speler_naam from speler where speler_id = '" + speler_id + "' ", db.connectiestring());

                waarde = (int)cm5.ExecuteScalar();

                //return gekozenid;
                return speler_naam;
            }
            catch (Exception fout)
            {
                Console.WriteLine(fout);
            }
            finally
            {
                db.CloseConnection();
            }

            return speler_naam;
        }

        public override string ToString()
        {
            return speler_naam + " Lengte: " + lengte + " Waarde: " + waarde;
        }

        public bool checkspeler()
        {
            db.OpenConn();
            MySqlCommand checkvoorspeler = new MySqlCommand("select * from speler where speler_naam = '" + speler_naam + "' ", db.connectiestring());

            MySqlDataReader reader = checkvoorspeler.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool toevoegenspeler()
        {
            db.OpenConn();
            var command = db.connectiestring().CreateCommand();
            command.Parameters.AddWithValue("@speler_naam", speler_naam);
            command.Parameters.AddWithValue("@team_id", team_id);
            command.Parameters.AddWithValue("@speler_lengte", lengte);
            command.Parameters.AddWithValue("@speler_transferwaarde", waarde);
            command.CommandText = "INSERT INTO speler (speler_naam, team_id, speler_lengte, speler_transferwaarde ) VALUES (@speler_naam, @team_id, @speler_lengte, @speler_transferwaarde)";
            bool result = checkspeler();
            if (result == false)
            {
                command.ExecuteNonQuery();
            }

            db.CloseConnection();
            return result;
        }
    }
}