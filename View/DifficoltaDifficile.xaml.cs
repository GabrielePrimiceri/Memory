using CommunityToolkit.Mvvm.Input;
using ProjectWork_Memory.ViewModel;

namespace ProjectWork_Memory.View;

public partial class DifficoltaDifficile : ContentPage
{
	private DifficoltaDifficileViewModel _viewModel;
	public DifficoltaDifficile()
	{
		InitializeComponent();
		BindingContext = _viewModel= new DifficoltaDifficileViewModel();
		matriceBottoniGrid = new Button[8, 4];
		int contatoreColonne = 0;
		int contatoreRighe = 0;
		for (int i = 0; i< GameGrid.Children.Count; i++)
		{
			contatoreColonne++;

			if (GameGrid.Children[i] is Button)
			{
				if (contatoreColonne == 4)
				{
					contatoreColonne = 0;
					contatoreRighe++;
				}
				matriceBottoniGrid[contatoreRighe, contatoreColonne] = (Button)GameGrid.Children[i];
            }

        }
	}

	Button[,] matriceBottoniGrid;

	[RelayCommand]
	public async void UsaBottone(object sender)
	{
		Button button = sender as Button;
		await _viewModel.UsaBottone(button, matriceBottoniGrid);
	}
}