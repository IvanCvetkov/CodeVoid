﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Arrays
{
    /// <summary>
    /// Interaction logic for Arrays.xaml
    /// </summary>
    public partial class Arrays : Page
    {
        public Arrays()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Grid
            DoubleAnimation alertGridAnim = new DoubleAnimation()
            {
                From = MinWidth,
                To = 1700,
                Duration = TimeSpan.FromSeconds(2),

                EasingFunction = new QuinticEase()
            };

            gr.BeginAnimation(WidthProperty, alertGridAnim);
        }
        private void BackToExercises_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
