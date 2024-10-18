using Core.Interfaces;

namespace Core.Services;

public class CountingService : ICountingService
{
    public int CurrentCount { get; private set; }
    
    public void Increment()
    {
        CurrentCount++;
    }

    public void Reset()
    {
        CurrentCount = 0;
    }
}