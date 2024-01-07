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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        MainWindow mainWindow;
        public Profile()
        {
            InitializeComponent();
        }

        public void SetUserControls(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void SetInfo()
        {
            profileName.Content = mainWindow.currentUser.Email.ToString();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MenuChoiceVisibility(mainWindow.movieDisplay);
            this.Visibility = Visibility.Hidden;
        }
    }
}
