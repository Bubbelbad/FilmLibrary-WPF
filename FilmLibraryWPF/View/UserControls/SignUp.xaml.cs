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

        public SignUp()
        {
            InitializeComponent();
            tbFullName.ChangeText("Full name");
            tbEmail.ChangeText("Email");
            tbPassword.ChangeText("Password");
        }


        public void SetUserManager(UserManager userManager1)
        {
            this.userManager = userManager1;
        }


        public void SignUpGridVisible()
        {
            if (signUpGrid.Visibility == Visibility.Hidden)
            {
                signUpGrid.Visibility = Visibility.Visible;
            }
            else if (signUpGrid.Visibility == Visibility.Visible)
            {
                signUpGrid.Visibility = Visibility.Hidden;
            }
        }


        private void btnSignUpDone_Click(object sender, RoutedEventArgs e)
        {
            string fullName = tbFullName.ToString();
            string user = tbEmail.ToString();
            string password = tbPassword.ToString();
            userManager.CreateUser(fullName, user, password);
            SignUpGridVisible();
        }


    }
}
