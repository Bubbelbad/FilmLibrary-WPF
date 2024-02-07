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
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : UserControl
    {
        MenuBar menuBar;
        UserManager userManager;
        MainWindow mainWindow;

        public void SetUserControls(MenuBar menuBar, UserManager userManager,MainWindow mainWindow)
        {
            this.menuBar = menuBar;
            this.userManager = userManager;
            this.mainWindow = mainWindow;
        }

        public UserMenu()
        {
            InitializeComponent();
        }


        private void profileBtn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MenuChoiceVisibility(mainWindow.profile);
        }

        private void logOutBtn_Click(object sender, RoutedEventArgs e)
        {
            userManager.currentUser = null;
            mainWindow.SetCurrentUser();
            mainWindow.menuBar.UpdateUserName();
            mainWindow.LogInOrSignUpVisible(mainWindow.logInWindow);
            mainWindow.profile.Visibility = Visibility.Hidden;
            mainWindow.settings.Visibility = Visibility.Hidden;
            mainWindow.movieDisplay.Visibility = Visibility.Hidden;
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MenuChoiceVisibility(mainWindow.settings);
        }
    }
}
