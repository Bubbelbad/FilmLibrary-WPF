using FilmLibraryWPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void btn_darkTheme_Click(object sender, RoutedEventArgs e)
        {
            PanelVisibility(settingsPanel);
        }

        private void btn_profileInfo_Click(object sender, RoutedEventArgs e)
        {
            PanelVisibility(profilePanel);
        }

        //Function that makes desired SpackPanel visible, and the rest of them hidden. 
        public void PanelVisibility(StackPanel panel)
        {
            if (panel.Visibility == Visibility.Hidden)
            {
                panel.Visibility = Visibility.Visible;
                if (panel == profilePanel)
                {
                    settingsPanel.Visibility = Visibility.Hidden;
                }
                else
                {
                   profilePanel.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                panel.Visibility = Visibility.Visible;
               // userMenu.Visibility = Visibility.Hidden;
            }
        }
    }
}
