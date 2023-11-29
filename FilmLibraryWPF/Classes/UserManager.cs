using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryWPF.Classes
{
    public class UserManager
    {
        List<User> listOfUsers = new List<User>();

        public UserManager()
        {

        }


        public void CreateUser(string fullName, string email, string password)
        {
            listOfUsers.Add(new User(fullName, email, password));
        }
    }
}
