namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents an author field of an <see cref="IMariDiscordEmbed"/>.
    /// </summary>
    public interface IMariDiscordEmbedAuthor
    {
        /// <summary>
        /// The name of the author field.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The URL of the author field.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// The icon URL of the author field.
        /// </summary>
        string IconUrl { get; }

        /// <summary>
        /// The proxified icon URL of the author field.
        /// </summary>
        string ProxyIconUrl { get; }
    }
}