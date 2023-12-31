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
    /// Interaction logic for MovieDisplay.xaml
    /// </summary>
    public partial class MovieDisplay : UserControl
    {
        MainWindow mainWindow;

        public MovieDisplay()
        {
            InitializeComponent();
        }

        public void SetUserControls(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        private void Movie1_MouseEnter(object sender, MouseEventArgs e)
        {
            Movie1.Height += 10;
            Movie1.Width += 10;
        }
    }
}
