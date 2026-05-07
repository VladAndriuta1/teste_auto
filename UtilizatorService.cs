using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

using teste_auto;

public class UtilizatorService
{
    public bool Inregistreaza(string nume, string prenume, string email, string parola)
    {
        try
        {
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO utilizatori (nume, prenume, email, parola, rol) " +
                               "VALUES (@nume, @prenume, @email, @parola, 'candidat')";
                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@prenume", prenume);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@parola", parola);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Eroare: " + ex.Message);
            return false;
        }
    }

    public Utilizator Login(string email, string parola)
    {
        try
        {
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM utilizatori WHERE email=@email AND parola=@parola";
                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@parola", parola);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Utilizator
                    {
                        Id = reader.GetInt32("id"),
                        Nume = reader.GetString("nume"),
                        Prenume = reader.GetString("prenume"),
                        Email = reader.GetString("email"),
                        Rol = reader.GetString("rol")
                    };
                }
                return null;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Eroare: " + ex.Message);
            return null;
        }
    }

    public bool EmailExista(string email)
    {
        using (var con = DatabaseHelper.GetConnection())
        {
            con.Open();
            string query = "SELECT COUNT(*) FROM utilizatori WHERE email=@email";
            var cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}