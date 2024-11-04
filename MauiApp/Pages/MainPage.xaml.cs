using Core.ViewModels;

namespace MobileCounter.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		var vm = ServiceHelper.GetService<MainPageViewModel>();
		BindingContext = vm;
	}
}