using System;
using System.Collections.Generic;
using System.Text;
using BepInEx.Logging;

namespace GorillaTagModTemplateProject.Helpful
{
    public class GTLogger
    {
        static ManualLogSource logSource;
        public static void SetupLogger(ManualLogSource manuel)
        {
            logSource = manuel;
        }

        private static void DoLog(string message, LogLevel level)
        {
            if (logSource == null)
                return;
            switch (level)
            {
                case LogLevel.Info:
                    logSource.LogInfo(message);
                    break;
                case LogLevel.Warning:
                    logSource.LogWarning(message);
                    break;
                case LogLevel.Error:
                    logSource.LogError(message);
                    break;
                case LogLevel.Debug:
                    logSource.LogDebug(message);
                    break;
                default:
                    logSource.LogInfo(message);
                    break;
            }
        }

        public static void Log(string message) => DoLog(message, LogLevel.Info);
        public static void LogWarning(string message) => DoLog(message, LogLevel.Warning);
        public static void LogError(string message) => DoLog(message, LogLevel.Error);
        public static void LogDebug(string message) => DoLog(message, LogLevel.Debug);
    }
}
