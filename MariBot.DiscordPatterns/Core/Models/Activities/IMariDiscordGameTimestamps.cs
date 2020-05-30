using System;

namespace MariBot.DiscordPatterns.Core.Models.Activities
{
    /// <summary>
    /// Timestamps for a <see cref="IMariDiscordRichGame" /> object.
    /// </summary>
    public interface IMariDiscordGameTimestamps
    {
        /// <summary>
        /// When the activity started.
        /// </summary>
        DateTimeOffset? Start { get; }

        /// <summary>
        /// When the activity ends.
        /// </summary>
        DateTimeOffset? End { get; }
    }
}