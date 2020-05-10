namespace MariBot.DiscordPatterns.Core.Models.Emotes
{
    /// <summary>
    /// Represents a custom image-based emote.
    /// </summary>
    public interface IMariDiscordCustomEmote : IMariDiscordEmote, IMariDiscordSnowFlakeEntity
    {
        /// <summary>
        /// Whether this emote is animated.
        /// </summary>
        bool Animated { get; }

        /// <summary>
        /// The url of the image of this emote.
        /// </summary>
        string Url { get; }
    }
}