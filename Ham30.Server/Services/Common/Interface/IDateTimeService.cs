using System;

namespace Ham30.Server.Services.Common.Interface
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}