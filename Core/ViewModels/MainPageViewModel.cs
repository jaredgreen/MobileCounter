using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Core.Interfaces;

namespace Core.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly ICountingService _countingService;

    public string ClickedCount
    {
        get
        {
            var currentCount = _countingService.CurrentCount;

            if (currentCount == 0)
            {
                return "Click Me";
            }
            if (currentCount == 1)
            {
                return $"Clicked {currentCount} time";
            }
            return $"Clicked {currentCount} times";
        }
    }

    public MainPageViewModel(ICountingService countingService)
    {
        _countingService = countingService;
    }

    [RelayCommand]
    private void Increment()
    {
        _countingService.Increment();
        OnPropertyChanged(nameof(ClickedCount));
    }

    [RelayCommand]
    private void Reset()
    {
        _countingService.Reset();
        OnPropertyChanged(nameof(ClickedCount));
    }
}