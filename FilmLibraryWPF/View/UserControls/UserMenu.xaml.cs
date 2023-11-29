﻿using System;
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
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : UserControl
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        public void userMenuGridVisible()
        {
            if (userMenuGrid.Visibility == Visibility.Hidden)
            {
                userMenuGrid.Visibility = Visibility.Visible;
            }
            else if (userMenuGrid.Visibility == Visibility.Visible)
            {
                userMenuGrid.Visibility = Visibility.Hidden;
            }
        }
    }
}