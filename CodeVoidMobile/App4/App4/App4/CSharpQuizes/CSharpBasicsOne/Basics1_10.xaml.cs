﻿using System;
using App4.Awaitable;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics1_10 : ContentPage
    {
        public Basics1_10()
        {
            InitializeComponent();
        }

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (Answer.Text == "15")
            {
                await Task.Delay(250);
                await Navigation.PushAsync(new SuccessPage());
                await Task.Delay(2500);
                await Navigation.PushAsync(new Basics2_10());
            }
            else
            {
                App.Counter++;
                if (App.Counter == 3)
                {
                    await Navigation.PushAsync(new QuizFail());
                }
                else
                {
                    await Task.Delay(250);
                    await Navigation.PushAsync(new FailurePage());
                    await Task.Delay(2500);
                    await Navigation.PushAsync(new Basics2_10());
                }
            }
        }
        protected override bool OnBackButtonPressed()
        {
            BackButtonPressed();
            return true;
        }

        public async Task BackButtonPressed()
        {
            App.Counter = 0;
            var action = await DisplayAlert("Предупреждение", "Найстина ли искаш да излезеш от текущия тест?" +
                " Ако го направиш ще изгубиш своя прогрес до тук!", "Не", "Да");
            if (!action)
            {
                await Navigation.PushAsync(new CSharpQuiz());
            }
        }
    }
}