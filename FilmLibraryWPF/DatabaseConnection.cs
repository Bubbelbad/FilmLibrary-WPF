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
        string database = "FilmLibrary";
        string username = "user";
        string password = "password";

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
                Movie movie = new Movie((int)reader["Id"], (string)reader["Title"], (string)reader["Description"], (int)reader["Runtime"], (int)reader["Rating"], (int)reader["Release_Year"], (string)reader["movie_poster"]);
                movies.Add(movie.Id, movie);
            }
            connection.Close();
            return movies;
        }

        public Dictionary<int, User> GetUsers()
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM user;";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new User((int)reader["Id"], (string)reader["first_name"], (string)reader["last_name"], (string)reader["email"], (string)reader["password"],  (bool)reader["admin"]);
                users.Add(user.Id, user);
            }
            connection.Close();
            return users;
        }

        public void CreateNewUser(string firstName, string lastName, string email, string password)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO user VALUES (DEFAULT, " + 
                           "\"" + firstName + "\", \"" + lastName + "\", \"" + email + "\", \"" + password + "\", false);";
            MySqlCommand command = new MySqlCommand(query, con);
            int rowsAffected = command.ExecuteNonQuery();
            con.Close();
        }

        public void AddMovieToFavourites()
        {
            MySqlConnection con = new MySqlConnection();
            con.Open();
            string query = "CALL add_movie_to_favourite;";
            MySqlCommand command = new MySqlCommand( query, con);
            int rowsAffected = command.ExecuteNonQuery();
            con.Close();
        }
    }
}
