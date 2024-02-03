using FilmLibraryWPF.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryWPF
{
    class DatabaseConnection
    {
        string server = "localhost";
        string database = "MiniLibraryWPF";
        string username = "admin";
        string password = "admin";

        string connectionString = string.Empty;

        public DatabaseConnection()
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID" + username + ";" +
                "PASSWORD=" + password + ";";
        }

        public Dictionary<int, Movie> GetMovies()
        {
            Dictionary<int, Movie> movies = new Dictionary<int, Movie>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM movies;";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
               // Movie movie = new Movie((int)reader["Id"], (string(reader["Title"], (string)reader["Description"], (string)reader["Url]"]));
                //movies.Add(movie.Id, movie);
            }
            connection.Close();
            return movies;
            
        }
    }
}
