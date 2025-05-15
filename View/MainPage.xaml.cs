using Microsoft.Maui.Controls;
using ProjectWork_Memory.View;

namespace ProjectWork_Memory.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void IniziaPartita(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }

        private async void Regolamento(object sender, EventArgs e)
        {
            
        }

        private void Esci(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }
    }
}