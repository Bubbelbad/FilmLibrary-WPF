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
            listOfUsers.Add(new User("victor ivarson", "vullmail", "1234"));
        }


        public bool CreateUser(string fullName, string email, string password)
        {
            listOfUsers.Add(new User(fullName, email, password));
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
    }
}
