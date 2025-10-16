namespace ShortR.Application.Common.Interfaces.Time;

public interface ISystemClock
{
    DateTime UtcNow { get; }
}
