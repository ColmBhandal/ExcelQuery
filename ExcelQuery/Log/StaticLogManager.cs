using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelQuery.Log
{
    internal static class StaticLogManager
    {
        private static ILogger _logger;
        public static ILogger Logger
        {
            get => _logger ?? (_logger = new InactiveLoggerImpl());
            set => _logger = value;
        }
    }
}
