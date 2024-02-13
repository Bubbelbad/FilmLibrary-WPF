using FilmLibraryWPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace FilmLibraryWPF.View.UserControls
{
    /// <summary>
    /// Interaction logic for MovieDisplay.xaml
    /// </summary>
    public partial class MovieDisplay : UserControl
    {
        MainWindow mainWindow;
        MovieManager movieManager;
        DatabaseConnection databaseConnection;

        List<UserControls.Movie> moviesUsc = new List<UserControls.Movie>();
        Dictionary<int, Classes.Movie> movieDictionary = new Dictionary<int, Classes.Movie>();
        List<Classes.Movie> listOfMovies = new List<Classes.Movie>();

        public MovieDisplay()
        {
            InitializeComponent();
            moviesUsc.Add(Movie1);
            moviesUsc.Add(Movie2);
            moviesUsc.Add(Movie3);
            moviesUsc.Add(Movie4);
            moviesUsc.Add(Movie5);
            moviesUsc.Add(Movie6);
            moviesUsc.Add(Movie7);
            moviesUsc.Add(Movie8);
            moviesUsc.Add(Movie9);
            moviesUsc.Add(Movie10);
            moviesUsc.Add(Movie11);
            moviesUsc.Add(Movie12);
            moviesUsc.Add(Movie13);
            moviesUsc.Add(Movie14);
            moviesUsc.Add(Movie15);
            moviesUsc.Add(Movie16);
            moviesUsc.Add(Movie17);
            moviesUsc.Add(Movie18);
        }

        public void SetUserControls(MainWindow mainWindow, MovieManager movieManager, DatabaseConnection databaseConnection)
        {
            this.mainWindow = mainWindow;
            this.movieManager = movieManager;
            this.databaseConnection = databaseConnection;
            movieDictionary = databaseConnection.GetMovies();
            listOfMovies = movieDictionary.Values.ToList();
            ImportMovies();
        }

        public void ImportMovies()
        {
            for (int i = 0; i < 18; i++)
            {
                moviesUsc[i].label_movieTitle.Content = listOfMovies[i].Title;
                moviesUsc[i].label_movieRating.Content = $"Rating: {listOfMovies[i].Rating}%";
                //moviesUsc[i].
            }
        }

        //This method is supposed to enlarge the object, but is isn't working properly. 
        private void Movie1_MouseEnter(object sender, MouseEventArgs e)
        {
            Movie1.Height += 10;
            Movie1.Width += 10;
        }

        //This method is not optimal since it is not case-sensitive! Need to find another way.
        public void SearchMovies(string search)
        {
            int iterator = 0;
            for (int i = 0; i <  listOfMovies.Count; i++)
            {
                if (listOfMovies[i].Title.Contains(search))
                {
                    moviesUsc[iterator].Visibility = Visibility.Visible;
                    moviesUsc[iterator].label_movieTitle.Content = listOfMovies[i].Title;
                    moviesUsc[iterator].label_movieRating.Content = $"Rating: {listOfMovies[i].Rating}%";
                    iterator++;
                }
                else
                {
                    continue;
                }
            }
            for (int i = iterator; i < 18; i++)
            {
                moviesUsc[i].Visibility = Visibility.Hidden;
            }
        }
    }
}
