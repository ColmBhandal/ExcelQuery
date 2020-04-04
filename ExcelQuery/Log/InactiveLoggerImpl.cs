using System;

namespace ExcelQuery.Log
{
    internal class InactiveLoggerImpl : ILogger
    {
        public void Error(string message)
        {
        }

        public void Error(string message, Exception ex)
        {
        }
    }
}