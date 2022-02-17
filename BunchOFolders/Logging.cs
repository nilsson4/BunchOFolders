using System;
using System.Collections.Generic;

namespace BunchOFolders
{
    class Logging
    {
        public static ConsoleColor MessageColor = ConsoleColor.Blue;
        public static ConsoleColor WarningColor = ConsoleColor.Yellow;
        public static ConsoleColor ErrorColor = ConsoleColor.Red;
        public static void Log(string message, LogLevel logLevel)
        {
            if (logLevel == LogLevel.Message)
            {
                Console.ForegroundColor = MessageColor;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (logLevel == LogLevel.Warning)
            {
                Console.ForegroundColor = WarningColor;
                Console.WriteLine($"Warning: {message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (logLevel == LogLevel.Error)
            {
                Console.ForegroundColor = ErrorColor;
                Console.WriteLine($"ERROR: [{message}]");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
    enum LogLevel
    {
        Message,
        Warning,
        Error,
    };
}
