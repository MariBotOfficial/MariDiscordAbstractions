namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents a video featured in an <see cref="IMariDiscordEmbed"/>.
    /// </summary>
    public interface IMariDiscordEmbedVideo
    {
        /// <summary>
        /// The URL of the video.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// The height of the video.
        /// </summary>
        int? Height { get; }

        /// <summary>
        /// The weight of the video.
        /// </summary>
        int? Width { get; }
    }
}