using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Common
{
    /// <summary>
    /// Interface for event logging and tracing
    /// </summary>
    public interface ILogger
    {
        void Information(string message);
        void Information(string format, params object[] vars);
        void Information(Exception exception, string format, params object[] vars);

        void Warning(string message);
        void Warning(string format, params object[] vars);
        void Warning(Exception exception, string format, params object[] vars);

        void Error(string message);
        void Error(string format, params object[] vars);
        void Error(Exception exception, string format, params object[] vars);

        void TraceApi(string componentName, string method, TimeSpan timespan);
        void TraceApi(string componentName, string method, TimeSpan timespan, string properties);
        void TraceApi(string componentName, string method, TimeSpan timespan, string format, params object[] vars);

    }
}