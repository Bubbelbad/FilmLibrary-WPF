using FilmLibraryWPF.Classes;
using FilmLibraryWPF.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace FilmLibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //- Se till så att SignInWindow kan öppnas i MainWindow från MenuBar
        //- Gör så storleken anpassas efter skärmstorlek vid uppstart!
        //- Koppla inlogg till användare

        UserManager userManager;
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public User currentUser;
        List<UserControl> userControls = new List<UserControl>();

        Dictionary<int, Classes.Movie> movies = new Dictionary<int, Classes.Movie>();
        List<Classes.Movie> movieList = new List<Classes.Movie>();
        
        public MainWindow()
        {
            InitializeComponent();
            userManager = new UserManager(databaseConnection);
            menuBar.SetMainWindow(this);
            this.logInWindow.SetUserControls(menuBar, userManager, databaseConnection, this);
            this.signUpWindow.SetUserManagers(userManager, menuBar, databaseConnection, this);
            this.userMenu.SetUserControls(menuBar, userManager, this);
            this.profile.SetUserControls(this);
            this.settings.SetUserControls(this);
            this.movieDisplay.SetUserControls(this);
            userControls.Add(signUpWindow);
            userControls.Add(userMenu);
            userControls.Add(profile);
            userControls.Add(userMenu);
            userControls.Add(movieDisplay);
            movies = databaseConnection.GetMovies();
        }

        public void CurrentUser()
        {
            currentUser = userManager.CurrentUser();
            if (currentUser != null)
            {
                movieDisplay.Visibility = Visibility.Visible;
            }
        }

        public void LogInOrSignUpVisible(UserControl control)
        {
            if (control.Visibility == Visibility.Hidden)
            {
                control.Visibility = Visibility.Visible;
                menuBar.blurEffect.Radius = 5;
                userMenu.Visibility = Visibility.Hidden;
                if (control == signUpWindow)
                {
                    logInWindow.Visibility = Visibility.Hidden;
                }
                else
                {
                    signUpWindow.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                control.Visibility = Visibility.Hidden;
                menuBar.blurEffect.Radius = 0;
                userMenu.Visibility = Visibility.Hidden;
            }
        }

        //Takes the userControl from UserMenu that should be visible as argument and hides the rest of the userControls
        public void MenuChoiceVisibility(UserControl control)
        {
            control.Visibility = Visibility.Visible;
            foreach (UserControl item in userControls)
            {
                if (item != control)
                {
                    item.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
