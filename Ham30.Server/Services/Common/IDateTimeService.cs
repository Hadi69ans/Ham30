using System;

namespace Ham30.Server.Services.Common
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}