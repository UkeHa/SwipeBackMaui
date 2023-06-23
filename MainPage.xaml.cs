namespace SwipeBackFeature;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(SecondPage));
	}
}

