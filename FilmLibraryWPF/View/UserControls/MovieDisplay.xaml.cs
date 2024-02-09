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

namespace FilmLibraryWPF.View.UserControls
{
    /// <summary>
    /// Interaction logic for MovieDisplay.xaml
    /// </summary>
    public partial class MovieDisplay : UserControl
    {
        MainWindow mainWindow;
        MovieManager movieManager;

        List<UserControls.Movie> moviesUsc = new List<UserControls.Movie>();
        List <Classes.Movie> movies = new List<Classes.Movie>();
        

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
            moviesUsc.Add(Movie14);
            moviesUsc.Add(Movie15);
            moviesUsc.Add(Movie16);
            moviesUsc.Add(Movie17);
            moviesUsc.Add(Movie18);
        }

        public void SetUserControls(MainWindow mainWindow, MovieManager movieManager)
        {
            this.mainWindow = mainWindow;
            this.movieManager = movieManager;
           // movies = movieManager.
        }

        public void ImportMovies()
        {

        }

        private void Movie1_MouseEnter(object sender, MouseEventArgs e)
        {
            Movie1.Height += 10;
            Movie1.Width += 10;
        }
    }
}
