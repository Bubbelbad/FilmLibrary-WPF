using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FilmLibraryWPF.Classes
{
    public class User
    {

        public int Id { get; set; }
        private string FullName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        public static int nextId = 1;

        public User(string fullName, string email, string password)
        {
            this.FullName = fullName;
            this.Email = email;
            this.Password = password;
            this.Id = nextId++;
        }


        public bool LogIn(string email, string password)
        {
            if (email == null || password == null)
            {
                return false;
            }
            else if (email == this.Email.ToLower() && password == this.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
