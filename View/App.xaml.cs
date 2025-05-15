using ProjectWork_Memory.View;

namespace ProjectWork_Memory
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new NewPage1());
        }
    }
}
