using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryWPF.Classes
{
    class MovieManager
    {
        List<Movie> movies = new List<Movie>();

        public void AddMovie(string title, string description, string imagePath)
        {
            movies.Add(new Movie(title, description, imagePath));
        }


        public List<Movie> SearchMovie(string title)
        {
            List<Movie> searchResultMovies = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (title == movie.Title)
                {
                    searchResultMovies.Add(movie);
                    continue;
                }
                else
                {
                    continue;
                }
            }
            return searchResultMovies;
        }


        public void ExportMovieToJson()
        {

        }

    }
}
