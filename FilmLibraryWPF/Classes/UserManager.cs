using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FilmLibraryWPF.Classes
{
    public class UserManager
    {
        List<User> listOfUsers = new List<User>();
        User currentUser;

        public static string usersPath = "users.txt";


        public UserManager()
        {
            listOfUsers.Add(new User("victor ivarson", "vullmail", "1234"));
        }


        public bool CreateUser(string fullName, string email, string password)
        {
            listOfUsers.Add(new User(fullName, email, password));
            StreamWriter sw = new StreamWriter(usersPath, true);
            int index = listOfUsers.Count - 1;
            sw.WriteLine(listOfUsers[index].GetJson());
            sw.Close();
            return true;
        }


        internal bool LogInUser(string username, string password)
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

        public User CurrentUser()
        {
            return currentUser;
        }


      //  public void LoadUsersFromFile()
      //  {
      //      listOfUsers.Clear();
      //      using (StreamReader sr = new StreamReader(usersPath))
      //      {
      //          string line = sr.ReadLine();
      //          try
      //          {
      //              while (line != null)
      //              {
      //
      //
      //                  User user = 
      //                  line = sr.ReadLine();
      //              }
      //          }
      //          catch (Exception e)
      //          {
      //              Console.WriteLine(e.Message);
      //          }
      //      }
      //  }
    }
}
