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

        //Använd Kaggle.com för att få ner dataset med info om filmer för träning? 
        //Se till så att SignInWindow kan öppnas i MainWindow från MenuBar

        public MainWindow()
        {
            InitializeComponent();
            menuBar.SetMainWindow(this);
        }


        public void LogInVisible()
        {
            logInWindow.Visibility = Visibility.Visible;
        }
        

        public void SignUpVisible()
        {
            //signUpWindow.Visibility = Visibility.Visible;
        }
    }
}
