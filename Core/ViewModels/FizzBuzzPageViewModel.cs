using CommunityToolkit.Mvvm.ComponentModel;
using Core.Interfaces;

namespace Core.ViewModels;

public class FizzBuzzPageViewModel : ObservableObject
{
    private readonly ICountingService _countingService;
    private readonly IFizzBuzzCalculator _fizzBuzzCalculator;

    public string FizzBuzzValue
    {
        get
        {
            var count = _countingService.CurrentCount;
            var result = _fizzBuzzCalculator.Calculate(count);
            return result;
        }
    }

    public FizzBuzzPageViewModel(ICountingService countingService, IFizzBuzzCalculator fizzBuzzCalculator)
    {
        _countingService = countingService;
        _fizzBuzzCalculator = fizzBuzzCalculator;
    }

    public void Refresh()
    {
        OnPropertyChanged(nameof(FizzBuzzValue));
    }
}