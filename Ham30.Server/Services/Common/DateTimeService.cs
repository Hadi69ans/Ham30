﻿
using Ham30.Server.Services.Common.Interface;
using System;

namespace Ham30.Server.Services.Common
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}