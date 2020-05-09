namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents an image for an <see cref="IMariDiscordEmbed" />
    /// </summary>
    public interface IMariDiscordEmbedImage
    {
        /// <summary>
        /// The URL of the image.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// A proxied URL of this image.
        /// </summary>
        string ProxyUrl { get; }

        /// <summary>
        /// The height of this image.
        /// </summary>
        int? Height { get; }

        /// <summary>
        /// The width of this image.
        /// </summary>
        int? Width { get; }
    }
}