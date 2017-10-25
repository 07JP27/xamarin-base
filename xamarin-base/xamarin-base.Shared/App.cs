using Xamarin.Forms;
using xamarinbase.Views;

namespace xamarinbase
{
    public partial class App : Application
    {
        public App()
        {
            var content = new MyPage();

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
