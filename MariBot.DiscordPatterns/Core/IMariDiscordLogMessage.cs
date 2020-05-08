using System;
using Microsoft.Extensions.Logging;

namespace MariBot.DiscordPatterns.Core
{
    /// <summary>
    /// Represents a log message.
    /// </summary>
    public interface IMariDiscordLogMessage
    {
        /// <summary>
        /// The LogLevel.
        /// </summary>
        LogLevel LogLevel { get; set; }
        
        /// <summary>
        /// The message of this log.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// The source of this log.
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// The exception of this log, can be null.
        /// </summary>
        Exception Exception { get; set; }

        /// <summary>
        /// The date of this log.
        /// </summary>
        DateTime Date { get; set; }
    }
}