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
            if(sender is Button)
            {
                await Navigation.PushAsync(new DifficoltaDifficile());
            }
            
        }

        private async void Regolamento(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Regolamento());
        }
        private async void Esci_Clicked(object sender, EventArgs e)
        {
            bool confirmExit = await DisplayAlert("Conferma", "Vuoi davvero uscire dal gioco?", "Sì", "No");
            if (confirmExit)
            {
                Application.Current.Quit();
            }
        }
    }
}
