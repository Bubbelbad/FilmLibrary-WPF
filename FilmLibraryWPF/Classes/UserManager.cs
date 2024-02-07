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

       // public static string usersPath = "users.txt";
        

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


      //  public bool CreateUser(string fullName, string email, string password)
      //  {
      //      listOfUsers.Add(new User(fullName, email, password));
      //      return true;
      //  }


        public bool LogInUser(string username, string password)
        {
            User theOne;
            foreach(User user in listOfUsers)
            {
                if (user.GetName() == username)
                {
                    user.LogIn(username, password);
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


       // public void SaveListOfUsersToJson()
       // {
       //     string json = JsonConvert.SerializeObject(listOfUsers, Formatting.Indented);
       //     StreamWriter sw = new StreamWriter(usersPath);
       //     sw.WriteLine(json);
       //     sw.Close();
       // }


       // public void LoadListOfUsersFromFile()
       // {
       //     if (!File.Exists(usersPath))
       //     {
       //         listOfUsers.Add(new User("admin", "admin", "admin"));
       //
       //     }
       //     else
       //     {
       //         try
       //         {
       //             using (StreamReader sr = new StreamReader(usersPath))
       //             {
       //                 string json = sr.ReadToEnd();
       //                 listOfUsers = JsonConvert.DeserializeObject<List<User>>(json);
       //             }
       //         }
       //         catch
       //         {
       //             MessageBox.Show("Didnt work");
       //         }
       //     }
       // }
    }
}
