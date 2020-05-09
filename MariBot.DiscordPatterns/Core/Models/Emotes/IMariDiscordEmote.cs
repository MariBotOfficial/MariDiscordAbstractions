namespace MariBot.DiscordPatterns.Core.Models.Emotes
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