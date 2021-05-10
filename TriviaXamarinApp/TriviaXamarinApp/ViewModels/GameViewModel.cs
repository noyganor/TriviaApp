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
    class GameViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string question;
        public string Question
        {
            get
            {
                return this.question;
            }
            set
            {
                if (this.question != value)
                {
                    this.question = value;
                    OnPropertyChanged("Question");
                }
            }
        }
    }
}
