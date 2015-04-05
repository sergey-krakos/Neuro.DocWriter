using System;
using System.Diagnostics;
using System.Text;

namespace DW.Common
{
    public class Logger : ILogger
    {
        /// <summary>
        /// Logging implementation using Trace object
        /// </summary>
        public void Information(string message)
        {
            Trace.TraceInformation(message);
        }

        public void Information(string format, params object[] vars)
        {
            Trace.TraceInformation(format, vars);
        }

        public void Information(Exception exception, string format, params object[] vars)
        {
            Trace.TraceInformation(FormatExceptionMessage(exception, format, vars));
        }

        public void Warning(string message)
        {
            Trace.TraceWarning(message);
        }

        public void Warning(string format, params object[] vars)
        {
            Trace.TraceWarning(format, vars);
        }

        public void Warning(Exception exception, string format, params object[] vars)
        {
            Trace.TraceWarning(FormatExceptionMessage(exception, format, vars));
        }

        public void Error(string message)
        {
            Trace.TraceError(message);
        }

        public void Error(string format, params object[] vars)
        {
            Trace.TraceError(format, vars);
        }

        public void Error(Exception exception, string format, params object[] vars)
        {
            Trace.TraceError(FormatExceptionMessage(exception, format, vars));
        }

        public void TraceApi(string componentName, string method, TimeSpan timespan)
        {
            TraceApi(componentName, method, timespan, "");
        }

        public void TraceApi(string componentName, string method, TimeSpan timespan, string format, params object[] vars)
        {
            TraceApi(componentName, method, timespan, string.Format(format, vars));
        }
        public void TraceApi(string componentName, string method, TimeSpan timespan, string properties)
        {
            var message = String.Concat("Component:", componentName, ";Method:", method, ";Timespan:", timespan.ToString(), ";Properties:", properties);
            Trace.TraceInformation(message);
        }

        private static string FormatExceptionMessage(Exception exception, string format, object[] vars)
        {
            var sb = new StringBuilder();
            sb.Append(string.Format(format, vars));
            sb.Append(" Exception: ");
            sb.Append(exception);
            return sb.ToString();
        }
    }
}