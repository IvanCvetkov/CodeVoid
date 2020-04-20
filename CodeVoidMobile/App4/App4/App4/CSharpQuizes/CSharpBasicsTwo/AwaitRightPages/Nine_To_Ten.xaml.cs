﻿using App4.CSharpQuizes.CSharpBasicsTwo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsTwo.AwaitRightPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nine_To_Ten : ContentPage
    {
        public Nine_To_Ten()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await Task.Delay(2000);
            await Navigation.PushAsync(new Basics10_20());
        }
    }
}