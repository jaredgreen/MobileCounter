using Core.Interfaces;

namespace Core.Services;

public class CountingService : ICountingService
{
    public int CurrentCount { get; private set; } = default;
    
    public void Increment()
    {
        CurrentCount++;
    }

}