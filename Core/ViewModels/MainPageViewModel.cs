using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Core.Interfaces;

namespace Core.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly ICountingService _countingService;

    [ObservableProperty] 
    private string _clickedText = "Click Me";
    
    public MainPageViewModel(ICountingService countingService)
    {
        _countingService = countingService;
    }

    [RelayCommand]
    private void Increment()
    {
        _countingService.Increment();

        var currentCount = _countingService.CurrentCount;
        
        if (currentCount == 1)
            ClickedText = $"Clicked {currentCount} time";
        else
            ClickedText = $"Clicked {currentCount} times";
    }
}