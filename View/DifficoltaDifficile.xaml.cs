using CommunityToolkit.Mvvm.Input;
using ProjectWork_Memory.ViewModel;

namespace ProjectWork_Memory.View;

public partial class DifficoltaDifficile : ContentPage
{
	private DifficoltaDifficileViewModel _viewModel;
	public DifficoltaDifficile()
	{
		InitializeComponent();
		BindingContext = _viewModel = new DifficoltaDifficileViewModel();
	}

}