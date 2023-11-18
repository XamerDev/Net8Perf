using Net8Perf.ViewModels;

namespace Net8Perf.Views;

public partial class DetailsView : ContentPage
{
	DetailsViewModel _viewModel;
	public DetailsView(DetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }
}