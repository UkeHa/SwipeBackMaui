using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SwipeBackFeature.ViewModels
{
	public partial class SecondPageViewModel : ObservableObject
	{
		public SecondPageViewModel()
		{
			Greeting = "Hello World";
		}

		[ObservableProperty] 
		private string _greeting;

		[RelayCommand]
		private async Task Back()
		{
			var result = await Shell.Current.DisplayAlert("", "Want to go back?" , "OK", "Stay here!");
			if (result)
			{
				await Shell.Current.GoToAsync("..");
			}

			Console.WriteLine("staying here");
		}
	}
}
