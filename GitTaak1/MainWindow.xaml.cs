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

namespace GitTaak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void red_MouseEnter(object sender, MouseEventArgs e)
        {
            ChangeBackground(Brushes.Red);
        }
        private void yellow_MouseEnter(object sender, MouseEventArgs e)
        {
            ChangeBackground(Brushes.Yellow);
        }
        private void green_MouseEnter(object sender, MouseEventArgs e)
        {
            ChangeBackground(Brushes.Green);
        }
        private void blue_MouseEnter(object sender, MouseEventArgs e)
        {
            ChangeBackground(Brushes.Blue);
        }
        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            ChangeBackground(Brushes.LightGray);
        }

        private void ChangeBackground(Brush color)
        {
            gridKleuren.Background = color;
        }
    }
}
