using ShortR.Application.Common.Interfaces.Time;

namespace ShortR.Infrastructure.Time;

internal class DefaultSystemClock : ISystemClock
{
    public DateTime UtcNow => DateTime.UtcNow;
}
