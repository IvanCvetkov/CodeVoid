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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Alerts
{
    /// <summary>
    /// Interaction logic for VariablesAlert.xaml
    /// </summary>
    public partial class VariablesAlert : Window
    {
        public VariablesAlert()
        {
            InitializeComponent();
        }

        //Main Events
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AlertGridOpen();
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            AlertGridClose();
            //Application.Current.Dispatcher.BeginInvoke(new Action(Close));
        }

        //Animation Methods
        public void AlertGridOpen()
        {
            //Grid
            DoubleAnimation alertAnim = new DoubleAnimation
            {
                From = MinWidth,
                To = 400,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertGrid.BeginAnimation(WidthProperty, alertAnim);


            //Border
            DoubleAnimation border = new DoubleAnimation
            {
                From = MinWidth,
                To = 400,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertBorder.BeginAnimation(WidthProperty, border);
        }
        public async void AlertGridClose()
        {
            //Grid
            DoubleAnimation alert = new DoubleAnimation
            {
                From = 400,
                To = MinWidth,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertGrid.BeginAnimation(WidthProperty, alert);

            //Border
            DoubleAnimation border = new DoubleAnimation
            {
                From = 400,
                To = MinWidth,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertBorder.BeginAnimation(WidthProperty, border);


            await Task.Delay(1000);

            this.Close();
        }
    }
}
