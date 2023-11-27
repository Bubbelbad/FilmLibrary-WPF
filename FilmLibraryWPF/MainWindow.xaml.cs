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

        //Använd Kaggle.com för att få ner dataset med info om filmer. 
        //Frågor: 

        //Hur gör jag för att ändra text i mina ClearableTextBoxes från andra klasser? (Nu står det Browsing movies överallt..)
        //Hur ändrar jag så LoginWindow går från Hidden till Visible med klick från MainWindow? 
        //Ligger mina klasser rätt? Hur ska jag göra för att implementera UserControls på ett smart sätt? 

        public MainWindow()
        {
            InitializeComponent();
        }

        public void MakeLoginVisible()
        {
            logInWindow.Visibility = Visibility.Visible;
        }
    }
}
