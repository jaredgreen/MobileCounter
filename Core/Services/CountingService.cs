using Core.Interfaces;

namespace Core.Services;

public class CountingService : ICountingService
{
    public int CurrentCount { get; } = default;
    
    public void Increment()
    {
        throw new NotImplementedException();
    }

}