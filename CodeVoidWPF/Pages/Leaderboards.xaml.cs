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

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for Leaderboards.xaml
    /// </summary>
    public partial class Leaderboards : Page
    {
        public Leaderboards()
        {
            InitializeComponent();
        }

        private void BtnBackLB_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }
    }
}
