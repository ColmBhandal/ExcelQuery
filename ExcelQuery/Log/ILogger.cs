using System;

namespace ExcelQuery.Log
{
    public interface ILogger
    {
        void Error(string message);

        void Error(string message, Exception ex);
    }
}