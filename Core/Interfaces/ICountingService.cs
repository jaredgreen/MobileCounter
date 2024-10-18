namespace Core.Interfaces;

public interface ICountingService
{
    public int CurrentCount { get; }
    void Increment();
    void Reset();
}