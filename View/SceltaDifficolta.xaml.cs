namespace ProjectWork_Memory.View;

public partial class SceltaDifficolta : ContentPage
{
	public SceltaDifficolta()
	{
		InitializeComponent();
	}
    private async void OnEasyClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DifficoltaFacile());
    }

    private async void OnMediumClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DifficoltaMedia());
    }

    private async void OnHardClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DifficoltaDifficile());
    }
}