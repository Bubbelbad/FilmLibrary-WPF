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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : UserControl
    {
        UserManager userManager;
        MenuBar menuBar;
        DatabaseConnection databaseConnection;
        MainWindow mainWindow;

        public SignUp()
        {
            InitializeComponent();
            tbFullName.ChangeText("First name");
            tbLastName.ChangeText("Last name");
            tbEmail.ChangeText("Email");
            tbPassword.ChangeText("Password");
        }

        public void SetUserManagers(UserManager userManager1, MenuBar menubar1, DatabaseConnection databaseConnection1, MainWindow mainWindow1)
        {
            this.userManager = userManager1;
            this.menuBar = menubar1;
            this.databaseConnection = databaseConnection1;
            this.mainWindow = mainWindow1;
        }


        private void btnSignUpDone_Click(object sender, RoutedEventArgs e)
        {
            string firstName = tbFullName.txtInput.Text;
            string lastName = tbLastName.txtInput.Text;
            string email = tbEmail.txtInput.Text;
            string password = tbPassword.passwordBox.Password;

            if (CheckEmail(email))
            {
                userManager.CreateUser(firstName, lastName, email, password);
                tbFullName.txtInput.Text = "";
                tbLastName.txtInput.Text = "";
                tbEmail.txtInput.Text = "";
                tbPassword.passwordBox.Password = "";
                mainWindow.LogInOrSignUpVisible(this);
                MessageBox.Show("Success!");
            }
        }


        public bool CheckEmail(string email)
        {
            if (email != null && email.Contains("@") && email.Length >= 8)
            {

                return true;
            }
            else
            {
                MessageBox.Show("Invalid email! Try again");
                tbEmail.txtInput.Clear();
                return false;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.LogInOrSignUpVisible(this);
        }

        private void btnGoToLogin_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
