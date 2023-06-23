using SwipeBackFeature.ViewModels;

namespace SwipeBackFeature;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

