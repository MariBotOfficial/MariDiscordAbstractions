namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a footer field for an <see cref="IMariDiscordEmbed"/>.
    /// </summary>
    public interface IMariDiscordEmbedFooter
    {
        /// <summary>
        /// The text of the footer field.
        /// </summary>
        string Text { get; }

        /// <summary>
        /// The URL of the footer icon.
        /// </summary>
        string IconUrl { get; }

        /// <summary>
        /// The proxied URL of the footer icon link.
        /// </summary>
        string ProxyUrl { get; }
    }
}