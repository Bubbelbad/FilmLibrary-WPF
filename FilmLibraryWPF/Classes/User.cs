using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FilmLibraryWPF.Classes
{
    class User
    {

        public int Id { get; set; }
        private string Name { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        public static int nextId = 1;

        public User(string name, string lastName, string email, string password)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Id = nextId++;
        }
    }
}
