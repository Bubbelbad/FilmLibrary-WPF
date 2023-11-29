using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
