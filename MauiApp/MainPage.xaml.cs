using Core.Services;
using Core.ViewModels;

namespace MobileCounter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
		var vm = new MainPageViewModel(new CountingService());
		BindingContext = vm;
	}
}