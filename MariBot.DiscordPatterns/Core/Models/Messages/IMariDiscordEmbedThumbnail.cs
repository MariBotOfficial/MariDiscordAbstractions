namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a thumbnail featured in an <see cref="IMariDiscordEmbed"/>.
    /// </summary>
    public interface IMariDiscordEmbedThumbnail
    {
        /// <summary>
        /// The URL of the thumbnail.
        /// </summary>
        string Url { get; }

        /// <summary>
        ///     Gets a proxied URL of this thumbnail.
        /// </summary>
        string ProxyUrl { get; }

        /// <summary>
        /// The height of this thumbnail.
        /// </summary>
        int? Height { get; }

        /// <summary>
        /// The width of this thumbnail.
        /// </summary>
        int? Width { get; }
    }
}