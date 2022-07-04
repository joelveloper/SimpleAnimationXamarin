using SimpleAnimationXamarin.Views;
using Xamarin.Forms;

namespace SimpleAnimationXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SecondAnimationsPage();
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
