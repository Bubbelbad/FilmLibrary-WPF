using FilmLibraryWPF.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : UserControl
    {
        MenuBar menuBar;
        UserManager userManager;
        MainWindow mainWindow;


        public LoginWindow()
        {
            InitializeComponent();
            tbEmail.ChangeText("Email");
            tbPassword.ChangeText("Password");
        }


        public void SetUserControls(MenuBar menuBar, UserManager userManager, MainWindow mainWindow)
        {
            this.menuBar = menuBar;
            this.userManager = userManager;
            this.mainWindow = mainWindow;
        }


        public void LogInGridVisible()
        {
            if (logInGrid.Visibility == Visibility.Visible)
            {
                logInGrid.Visibility = Visibility.Hidden;
                menuBar.blurEffect.Radius = 0;
            }
            else if (logInGrid.Visibility == Visibility.Hidden)
            {
                logInGrid.Visibility = Visibility.Visible;
                menuBar.blurEffect.Radius = 5;
            }
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string user = tbEmail.txtInput.Text;
            string password = tbPassword.txtInput.Text;
            try
            {
                if (userManager.LogInUser(user, password))
                {
                    LogInGridVisible();
                    mainWindow.CurrentUser();
                    menuBar.UpdateUserName();
                }
                else
                {
                    tbPassword.txtInput.Clear();
                    tbEmail.txtInput.Clear();
                    MessageBox.Show("Wrong credentials!");
                }
            }
            catch
            {
                tbEmail.ChangeText("Email");
                tbPassword.ChangeText("Password");
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
