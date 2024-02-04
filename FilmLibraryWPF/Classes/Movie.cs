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
        public string Title { get; private set; }
        private string Description { get; set; }
        private string Runtime { get; set; }
        private int rating { get; set; }
        private int ReleaseYear { get; set; }

        public static int nextId = 1;

        public Movie(int id, string title, string description, string runtime, int rating, int releaseYear)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Runtime = runtime;
            this.rating = rating;
            this.ReleaseYear = releaseYear;
        }
    }
}
