namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents a message attachment found in a <see cref="IMariDiscordMessage"/>.
    /// </summary>
    public interface IMariDiscordAttachment : IMariDiscordSnowFlakeEntity
    {
        /// <summary>
        /// The filename of this attachment.
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// The url of this attachment.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// A proxied url of this attachment.
        /// </summary>
        string ProxyUrl { get; }

        /// <summary>
        /// The size of this attachment in bytes.
        /// </summary>
        int Size { get; }

        /// <summary>
        /// The height of this attachment.
        /// </summary>
        int? Height { get; }

        /// <summary>
        /// The width of this attachment.
        /// </summary>
        int? Width { get; }
    }
}