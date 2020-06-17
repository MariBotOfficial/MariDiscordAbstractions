namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a provider field for an <see cref="IMariDiscordEmbed"/>.
    /// </summary>
    public interface IMariDiscordEmbedProvider
    {
        /// <summary>
        /// The name of the provider.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The URL of the provider.
        /// </summary>
        string Url { get; }
    }
}