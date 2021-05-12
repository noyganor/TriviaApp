using System;
using System.Collections.Generic;
using System.Text;
using TriviaXamarinApp.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using TriviaXamarinApp.Services;

namespace TriviaXamarinApp.ViewModels
{
    class PrivateQuestionsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string questionText;
        public string QuestionText
        {
            get
            {
                return this.questionText;
            }
            set
            {
                if (this.questionText != value)
                {
                    this.questionText = value;
                    OnPropertyChanged("QuestionText");
                }
            }
        }

        

    }


}



    

