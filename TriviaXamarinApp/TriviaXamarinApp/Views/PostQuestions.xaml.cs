using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriviaXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostQuestions : ContentPage
    {
        public PostQuestions()
        {
            this.BindingContext = new PostQuestionsViewModel();
            InitializeComponent();
            App app = (App)App.Current;
            if (app.CurrentUser == null)
            {
                Page p = new Login();

                Navigation.PushModalAsync(p);
            }
        }
    }
}