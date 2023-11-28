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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : UserControl
    {
        public LoginWindow()
        {
            InitializeComponent();
            tbEmail.ChangeText("Email");
            tbPassword.ChangeText("Password");
        }

        public void LogInGridVisible()
        {
            logInGrid.Visibility = Visibility.Visible;
        }

        public bool CheckEmail(string email)
        {
            if (email != null && email.Contains("@") && email.Length >= 8)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Wrong email");
                return false;
            }
        }
    }
}
