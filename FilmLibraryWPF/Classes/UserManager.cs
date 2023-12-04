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
        List<User> listOfUsers = new List<User>();
        User currentUser;

        public static string usersPath = "users.txt";


        public UserManager()
        {
            
        }


        public User CurrentUser()
        {
            return currentUser;
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


        public void SaveListOfUsersToJson()
        {
            string json = JsonConvert.SerializeObject(listOfUsers, Formatting.Indented);
            StreamWriter sw = new StreamWriter(usersPath);
            sw.WriteLine(json);
            sw.Close();
        }

        public void LoadListOfUsersFromFile()
        {
            if (!File.Exists(usersPath))
            {
                MessageBox.Show("Nothing here");
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(usersPath))
                    {
                        string json = sr.ReadToEnd();
                        listOfUsers = JsonConvert.DeserializeObject<List<User>>(json);
                    }
                }
                catch
                {
                    MessageBox.Show("Didnt work");
                }
            }
        }
    }
}
