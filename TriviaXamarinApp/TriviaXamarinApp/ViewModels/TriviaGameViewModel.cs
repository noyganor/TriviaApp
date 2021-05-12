using System;
using System.Collections.Generic;
using System.Text;
using TriviaXamarinApp.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using TriviaXamarinApp.Services;
using TriviaXamarinApp.Views;

namespace TriviaXamarinApp.ViewModels
{
    class TriviaGameViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TriviaGameViewModel()
        {
            OnAppearing();
        }

        public virtual void OnAppearing()
        {
            App app = (App)App.Current;
            User u = app.CurrentUser;

            if (u != null)
            {
                string name = u.NickName;
                Title = $"Trivia Game, hello {name}";
            }
            else
            {
                Title = "Trivia Game";
            }
        }
        public Command StartGame => new Command(StartTriviaGame);
        public void StartTriviaGame()
        {
            App app = (App)App.Current;
            app.MainPage = new Game();
        }

        public Command LoginPageGame => new Command(MoveToLoginPage);
        public void MoveToLoginPage()
        {
            App app = (App)App.Current;
            app.MainPage.Navigation.PushModalAsync(new Login());
        }

        public Command RegisterPageGame => new Command(MoveToRegisterPage);
        public void MoveToRegisterPage()
        {
            App app = (App)App.Current;
            app.MainPage.Navigation.PushModalAsync(new Register());
        }

        private string title;
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (this.title != value)
                {
                    this.title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

       

        private string user1;
        public string User1
        {
            get
            {
                return this.user1;
            }
            set
            {
                if (this.user1 != value)
                {
                    this.user1 = value;
                    OnPropertyChanged("User1");
                }
            }
        }


    }
}
