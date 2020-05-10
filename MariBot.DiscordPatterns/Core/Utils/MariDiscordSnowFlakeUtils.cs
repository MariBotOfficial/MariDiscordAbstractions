using System;

// Copied from Discord.NET https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Utils/SnowflakeUtils.cs
namespace MariBot.DiscordPatterns.Core.Utils
{
    /// <summary>
    /// Provides a series of helper methods for handling snowflake identifiers.
    /// </summary>
    public static class MariDiscordSnowFlakeUtils
    {
        /// <summary>
        /// Resolves the time of which the snowflake is generated.
        /// </summary>
        /// <param name="value">The snowflake identifier to resolve.</param>
        /// <returns>
        /// A <see cref="DateTimeOffset" /> representing the time for when the object is geenrated.
        /// </returns>
        public static DateTimeOffset FromSnowflake(ulong value)
            => DateTimeOffset.FromUnixTimeMilliseconds((long)((value >> 22) + 1420070400000UL));

        /// <summary>
        /// Generates a pseudo-snowflake identifier with a <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="value">The time to be used in the new snowflake.</param>
        /// <returns>
        /// A <see cref="UInt64" /> representing the newly generated snowflake identifier.
        /// </returns>
        public static ulong ToSnowflake(DateTimeOffset value)
            => ((ulong)value.ToUnixTimeMilliseconds() - 1420070400000UL) << 22;
    }
}