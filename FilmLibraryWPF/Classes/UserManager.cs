using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace FilmLibraryWPF.Classes
{
    public class UserManager
    {
        DatabaseConnection databaseConnection;
        Dictionary<int, User> userDictionary = new Dictionary<int, User>();
        List<User> listOfUsers = new List<User>();
        public User currentUser;

        

        public UserManager(DatabaseConnection databaseConnection)
        {
           // LoadListOfUsersFromFile();
            this.databaseConnection = databaseConnection;
            userDictionary = databaseConnection.GetUsers();
            listOfUsers = userDictionary.Values.ToList();
        }


        public User CurrentUser()
        {
            return currentUser;
        }


        public bool CreateUser(string firstName, string lastName, string email, string password)
        {
            listOfUsers.Add(new User(firstName, lastName, email, password));
            databaseConnection.CreateNewUser(firstName, lastName, email, password);
            return true;
        }


        public bool LogInUser(string username, string password)
        {
            User theOne;
            foreach(User user in listOfUsers)
            {
                if (user.GetName() == username && user.LogIn(username, password))
                {
                    currentUser = user;
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }


        public DatabaseConnection VerifyIfAdmin()
        {
            if (currentUser.Admin == true)
            {
                return databaseConnection = new DatabaseConnection(true);
            }
            else
            {
                return databaseConnection;
            }
        }
    }
}
