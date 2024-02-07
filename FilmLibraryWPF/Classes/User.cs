using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FilmLibraryWPF.Classes
{
    public class User
    {
        List<Movie> watchLater = new List<Movie>();
        List<Movie> favourites = new List<Movie>();

        public int Id { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

        public static int nextId = 1;

        public User(int id, string fullName, string lastName, string email, string password, bool admin)
        {
            this.Id = id;
            this.FullName = fullName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Admin = admin;
        }


        public string GetName()
        {
            return this.Email;
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


        public void AddMovie(string list)
        {
            throw new NotImplementedException();
        }
    }
}
