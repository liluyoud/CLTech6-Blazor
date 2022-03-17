using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTech.Core.Extensions
{
    public static class TimeExtensions
    {
        public static TimeSpan GetDuration(this DateTimeOffset? start, DateTimeOffset? end)
        {
            return end?.Subtract(start ?? end ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;
        }
    }
}
