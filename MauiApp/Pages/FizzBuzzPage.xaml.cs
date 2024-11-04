using Core.ViewModels;

namespace MobileCounter.Pages;

public partial class FizzBuzzPage : ContentPage
{
    private FizzBuzzPageViewModel _vm;

    public FizzBuzzPage()
    {
        InitializeComponent();

        _vm = ServiceHelper.GetService<FizzBuzzPageViewModel>();
        BindingContext = _vm;
    }

    protected override void OnAppearing()
    {
        _vm.Refresh();
    }
}