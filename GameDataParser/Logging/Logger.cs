﻿namespace GameDataParser.Logging
{
    public class Logger
    {
        private readonly string _logFileName;

        public Logger(string log)
        {
            _logFileName = log;
        }

        public void Log(Exception ex)
        {
            var entry =
                $@"[{DateTime.Now}]
            Exception message: {ex.Message}
            Stack trace: {ex.StackTrace}

            ";

            File.AppendAllText(_logFileName, entry);
        }
    }
}