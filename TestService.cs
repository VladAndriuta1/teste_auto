using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace teste_auto           
{
    public class TestService
    {
        public List<Intrebare> GetIntrebariAleatorii()
        {
            var intrebari = new List<Intrebare>();
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM intrebari ORDER BY RAND() LIMIT 24";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    intrebari.Add(new Intrebare
                    {
                        Id = reader.GetInt32("id"),
                        TextIntrebare = reader.GetString("text_intrebare"),
                        Categorie = reader.GetInt32("id_categorie").ToString()
                    });
                }
                reader.Close();

                foreach (var intrebare in intrebari)
                {
                    string q2 = "SELECT * FROM raspunsuri WHERE id_intrebare=@id ORDER BY RAND()";
                    var cmd2 = new MySqlCommand(q2, con);
                    cmd2.Parameters.AddWithValue("@id", intrebare.Id);
                    var r2 = cmd2.ExecuteReader();
                    while (r2.Read())
                    {
                        intrebare.Variante.Add(new Raspuns
                        {
                            Id = r2.GetInt32("id"),
                            IdIntrebare = r2.GetInt32("id_intrebare"),
                            TextRaspuns = r2.GetString("text_raspuns"),
                            EsteCorect = r2.GetBoolean("este_corect")
                        });
                    }
                    r2.Close();
                }
            }
            return intrebari;
        }

        public void SalveazaRezultat(int idUtilizator, int scor, int timpSecunde)
        {
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                bool promovat = scor >= 22;
                string query = "INSERT INTO teste (id_utilizator, scor, timp_secunde, promovat) " +
                               "VALUES (@id, @scor, @timp, @promovat)";
                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idUtilizator);
                cmd.Parameters.AddWithValue("@scor", scor);
                cmd.Parameters.AddWithValue("@timp", timpSecunde);
                cmd.Parameters.AddWithValue("@promovat", promovat ? 1 : 0);
                cmd.ExecuteNonQuery();
            }
        }

        public List<RezultatTest> GetIstoric(int idUtilizator)
        {
            var lista = new List<RezultatTest>();
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM teste WHERE id_utilizator=@id ORDER BY data_test DESC LIMIT 10";
                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idUtilizator);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new RezultatTest
                    {
                        IdUtilizator = idUtilizator,
                        Scor = reader.GetInt32("scor"),
                        TimpSecunde = reader.GetInt32("timp_secunde"),
                        Promovat = reader.GetBoolean("promovat"),
                        DataTest = reader.GetDateTime("data_test"),
                        TipTest = reader.GetString("tip_test")
                    });
                }
            }
            return lista;
        }

        public Tuple<int, int, int> GetStatistici(int idUtilizator)
        {
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT COUNT(*) as total, " +
                               "SUM(promovat=1) as trecute, " +
                               "SUM(promovat=0) as picate " +
                               "FROM teste WHERE id_utilizator=@id";
                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idUtilizator);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return Tuple.Create(
                        reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        reader.IsDBNull(2) ? 0 : reader.GetInt32(2)
                    );
                }
                return Tuple.Create(0, 0, 0);
            }
        }
    }
}   