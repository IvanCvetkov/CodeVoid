﻿using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Alerts
{
    /// <summary>
    /// Interaction logic for Failure.xaml
    /// </summary>
    public partial class Failure : Window
    {
        public Failure()
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
        }

        //Animation Methods
        public void AlertGridOpen()
        {
            //Grid
            DoubleAnimation alertGridAnim = new DoubleAnimation()
            {
                From = MinWidth,
                To = 400,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertGrid.BeginAnimation(WidthProperty, alertGridAnim);

            //Border
            DoubleAnimation border = new DoubleAnimation()
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
            DoubleAnimation alertGridAnim = new DoubleAnimation()
            {
                From = 400,
                To = MinWidth,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertGrid.BeginAnimation(WidthProperty, alertGridAnim);

            //Border
            DoubleAnimation border = new DoubleAnimation()
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
