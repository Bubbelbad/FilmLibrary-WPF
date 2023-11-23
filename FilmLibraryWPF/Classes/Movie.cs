using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryWPF.Classes
{
    class Movie
    {
        public int Id { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private string Url { get; set; }
        private int ReleaseYear { get; set; }

        public static int nextId = 1;

        public Movie(string title, string description, string url)
        {
            this.Title = title;
            this.Description = description;
            this.Id = nextId++;
        }
    }
}
