// Copied from https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Utils/SnowflakeUtils.cs

namespace MariBot.DiscordPatterns
{
    /// <summary>
    ///  Provides a series of helper methods for handling snowflake identifiers.
    /// </summary>
    public static class MariDiscordCDNUtils
    {
        /// <summary>
        ///  Returns an emoji URL.
        /// </summary>
        /// <param name="emojiId">The emoji snowflake identifier.</param>
        /// <param name="animated">Whether this emoji is animated.</param>
        /// <returns>
        /// A URL pointing to the custom emote.
        /// </returns>
        public static string GetEmojiUrl(ulong emojiId, bool animated)
            => $"{IMariDiscordSocketClientConfig.CDNUrl}emojis/{emojiId}.{(animated ? "gif" : "png")}";
    }
}