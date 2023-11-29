using System;
using System.Collections.Generic;
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

        public UserManager()
        {

        }


        public void CreateUser(string fullName, string email, string password)
        {
            listOfUsers.Add(new User(fullName, email, password));
        }


        internal bool LogInUser(string username, string password)
        {
            foreach(User user in listOfUsers)
            {
                if (user.LogIn(username, password))
                {
                    currentUser = user;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
