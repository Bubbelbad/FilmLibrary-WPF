using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryWPF.Classes
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; private set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public int rating { get; set; }
        public int ReleaseYear { get; set; }

        public static int nextId = 1;

        List<string> movieCategorys = new List<string>();

        public Movie(int id, string title, string description, int runtime, int rating, int releaseYear)
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
