using System;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    ///  Represents a Mari discord result.
    /// </summary>
    public interface IMariDiscordResult
    {
        /// <summary>
        /// When the result is success.
        /// </summary>
        bool IsSuccess { get; }

        /// <summary>
        /// The reason of this error.
        /// </summary>
        string Reason { get; }

        /// <summary>
        /// The exception if any ocurried.
        /// </summary>
        Exception Exception { get; }
    }
}