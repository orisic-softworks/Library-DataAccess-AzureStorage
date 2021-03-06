﻿namespace OSW.Lib.DataAccess.AzureStorage.Logic.Helper
{
    using System;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// The Logging Extentions
    /// </summary>
    internal static class LoggingExtentions
    {
        /// <summary>
        /// Logs that an exception has occured.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodName">Name of the method.</param>
        public static void LogException(this ILogger logger, Exception exception, string className, string methodName)
        {
            logger.LogInformation($"Exception in {className}.{methodName}: {exception}");
        }

        /// <summary>
        /// Logs that the method has ended.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodName">Name of the method.</param>
        public static void MethodEnd(this ILogger logger, string className, string methodName)
        {
            logger.LogInformation($"Method end: {className}.{methodName}");
        }

        /// <summary>
        /// Logs that the method has started.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodName">Name of the method.</param>
        public static void MethodStart(this ILogger logger, string className, string methodName)
        {
            logger.LogInformation($"Method start: {className}.{methodName}");
        }
    }
}