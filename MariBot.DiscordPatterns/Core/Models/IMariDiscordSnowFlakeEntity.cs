using System;

namespace MariBot.DiscordPatterns.Core.Models
{
    /// <summary> Represents a Discord snowflake entity. </summary>
    public interface IMariDiscordSnowFlakeEntity : IMariDiscordEntity<ulong>
    {
        /// <summary>
        /// When the snowflake was created.
        /// </summary>
        DateTimeOffset CreatedAt { get; }
    }
}