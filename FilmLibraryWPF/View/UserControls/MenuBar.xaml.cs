using FilmLibraryWPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FilmLibraryWPF.View.UserControls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        MainWindow mainWindow;

        public MenuBar()
        {
            InitializeComponent();
        }

        public void UpdateUserName()
        {
            if (mainWindow.currentUser == null)
            {
                btn_userMenu.Content = "";
                btn_userMenu.Visibility = Visibility.Hidden;
                btn_logIn.Visibility = Visibility.Visible;
                btn_signUp.Visibility = Visibility.Visible;   
            }
            else
            {
                btn_userMenu.Visibility = Visibility.Visible;
                btn_userMenu.Content = mainWindow.currentUser.FullName;
                btn_logIn.Visibility = Visibility.Hidden;
                btn_signUp.Visibility = Visibility.Hidden;
            }
        }

        public void SetMainWindow(MainWindow mainWindow1)
        {
            this.mainWindow = mainWindow1;
        }

        //Exit
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        //File
        private void MenuFile_Click(object sender, RoutedEventArgs e)
        {

        }

        //Save
        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {

        }

        //About
        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a Film Library App made by @Bubbelbad" +
                            "\nYou can find the code on github! ");
        }

        private void logInWindow_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.LogInOrSignUpVisible(mainWindow.logInWindow);
        }

        private void signInWindow_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.LogInOrSignUpVisible(mainWindow.signUpWindow); 
        }

        private void btn_userMenu_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow.userMenu.Visibility == Visibility.Visible)
            {
                mainWindow.userMenu.Visibility = Visibility.Hidden;
            }
            else
            {
                mainWindow.userMenu.Visibility = Visibility.Visible;
            }
        }
    }
}
