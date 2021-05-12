using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TriviaXamarinApp.Services;
using TriviaXamarinApp.Models;
using System.Threading.Tasks;
using TriviaXamarinApp.Views;
using Xamarin.Essentials;

namespace TriviaXamarinApp
{
    public partial class App : Application
    {
        public User CurrentUser { get; set; }
        public App()
        {
            Task<string> TaskEmail = SecureStorage.GetAsync("email");
            Task<string> TaskPassword = SecureStorage.GetAsync("password");
            TaskEmail.Wait();
            TaskPassword.Wait();
            string email = TaskEmail.Result;
            string password = TaskPassword.Result;

            InitializeComponent();

            Page p = new HomePage();
            MainPage = new NavigationPage(p);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
