﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Configuration;

namespace CodeVoidWPF.Pages.MainPages.Location
{
    /// <summary>
    /// Interaction logic for Location.xaml
    /// </summary>
    public partial class Location : Page
    {
        public Location()
        {
            InitializeComponent();
        }
        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void School_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void City_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Subject_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            CheckMethod();
            HomeMethod();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Subject_send();
        }

        //page methods
        public void CheckMethod()
        {
            //Sets all toolbox items on the page to an inactive state.
            if (Submit.IsEnabled == true)
                Submit.IsEnabled = false;

            if (FirstName.IsEnabled == true)
                FirstName.IsEnabled = false;

            if (LastName.IsEnabled == true)
                LastName.IsEnabled = false;

            if (School.IsEnabled == true)
                School.IsEnabled = false;

            if (City.IsEnabled == true)
                City.IsEnabled = false;

            if (Subject.IsEnabled == true)
                Subject.IsEnabled = false;

            if (Phone.IsEnabled == true)
                Phone.IsEnabled = false;
        }
        public async void HomeMethod()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
        }
        public void Subject_send()
        {
            if (MainPage.IsEnabled == true)
                MainPage.IsEnabled = false;

            if (FirstName.IsEnabled == true)
                FirstName.IsEnabled = false;

            if (LastName.IsEnabled == true)
                LastName.IsEnabled = false;

            if (School.IsEnabled == true)
                School.IsEnabled = false;

            if (City.IsEnabled == true)
                City.IsEnabled = false;

            if (Subject.IsEnabled == true)
                Subject.IsEnabled = false;

            if (Phone.IsEnabled == true)
                Phone.IsEnabled = false;

            //Initializing the information necessary
            string subject = "\t\t|" + Subject.Text + "|";
            string UserInformation = FirstName.Text + " " + LastName.Text + "\n" +
                                     Phone.Text + "\n" +
                                     School.Text + "\n" +
                                     City.Text;
            string RTBtext = new TextRange(MessageRTB.Document.ContentStart, MessageRTB.Document.ContentEnd).Text;
            string CodeVoidCopyRight = "CopyRight© CodeVoid";
            string message = @"" + subject + "\n" +
                             RTBtext + "\n" +
                             UserInformation + "\n" +
                             CodeVoidCopyRight;
            string[] Credentials = new string[3]{ "codevoiddummy@gmail.com",
                "codevoidauthentication", "codevoidreceiver@gmail.com" };

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(Credentials[0], Credentials[1]),
                EnableSsl = true
            };

            //sending the E-mail to the receiver from the dummy
            client.Send(Credentials[0], Credentials[2], subject, message);

            //Alert Message
            Alert alert = new Alert();
            alert.Show();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //Information Boxes CleanUp
        private void Message_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string Message = new TextRange(MessageRTB.Document.ContentStart, MessageRTB.Document.ContentEnd).Text;
            if (Message == "*Your Message")
            {
                MessageRTB = null;
            }
        }
        private void FirstName_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (FirstName.Text == "*First Name")
            {
                FirstName.Clear();
            }
        }
        private void LastName_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (LastName.Text == "*Last Name")
            {
                LastName.Clear();
            }
        }
        private void Subject_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Subject.Text == "*Subject")
            {
                Subject.Clear();
            }
        }
         private void Phone_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Phone.Text == "*Phone")
            {
                Phone.Clear();
            }
        }
        private void School_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (School.Text == "*School")
            {
                School.Clear();
            }
        }
        private void City_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (City.Text == "*City")
            {
                City.Clear();
            }
        }
        

        //Information Boxes Redefinition
        private void FirstName_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (FirstName.Text == null)
            {
                FirstName.Text = "*First Name";
            }
        }


    }
}
