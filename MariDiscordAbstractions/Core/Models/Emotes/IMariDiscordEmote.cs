namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a Discord's emote.
    /// </summary>
    public interface IMariDiscordEmote
    {
        /// <summary>
        /// The name or the unicode representation of this emote.
        /// </summary>
        string Name { get; }
    }
}