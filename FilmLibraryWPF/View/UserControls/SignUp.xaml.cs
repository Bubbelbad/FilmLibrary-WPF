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

        public SignUp()
        {
            InitializeComponent();
            tbFullName.ChangeText("Full name");
            tbEmail.ChangeText("Email");
            tbPassword.ChangeText("Password");
        }

        public void SetUserManagers(UserManager userManager1, MenuBar menubar)
        {
            this.userManager = userManager1;
            this.menuBar = menubar;
        }


        public void SignUpGridVisible()
        {
            if (signUpGrid.Visibility == Visibility.Hidden)
            {
                signUpGrid.Visibility = Visibility.Visible;
                menuBar.blurEffect.Radius = 5;
            }
            else if (signUpGrid.Visibility == Visibility.Visible)
            {
                signUpGrid.Visibility = Visibility.Hidden;
                menuBar.blurEffect.Radius = 0;
            }
        }


        private void btnSignUpDone_Click(object sender, RoutedEventArgs e)
        {
            string fullName = tbFullName.txtInput.Text;
            string email = tbEmail.txtInput.Text;
            string password = tbPassword.txtInput.Text;

            if (CheckEmail(email))
            {
                userManager.CreateUser(fullName, email, password);
                SignUpGridVisible();
                userManager.SaveListOfUsersToJson();
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
    }
}
