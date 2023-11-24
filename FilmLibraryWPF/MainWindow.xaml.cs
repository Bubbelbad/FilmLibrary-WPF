using FilmLibraryWPF.View.UserControls;
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

namespace FilmLibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Använd Kaggle.com för att få ner dataset med info om filmer. 

        public MainWindow()
        {
            
            
        }

        public void logIn()
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Visibility = Visibility.Visible;
        }

    }
}
