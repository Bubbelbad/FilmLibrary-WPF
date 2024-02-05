using FilmLibraryWPF.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryWPF
{
    public class DatabaseConnection
    {
        string server = "localhost";
        string database = "Filmlibrary";
        string username = "admin";
        string password = "admin";

        string connectionString = "";

        public DatabaseConnection()
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
        }

        public DatabaseConnection(bool admin)
        {
            if (admin == true)
            {
                connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + "admin" + ";" +
                "PASSWORD=" + "admin" + ";";
            }
        }

        public Dictionary<int, Movie> GetMovies()
        {
            Dictionary<int, Movie> movies = new Dictionary<int, Movie>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM movie;";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Movie movie = new Movie((int)reader["Id"], (string)reader["Title"], (string)reader["Description"], (int)reader["Runtime"], (int)reader["Rating"], (int)reader["Release_Year"]);
                movies.Add(movie.Id, movie);
            }
            connection.Close();
            return movies;
        }
    }
}
