namespace MariBot.DiscordPatterns.Core.Models.Activities
{
    /// <summary>
    /// Party secret for a <see cref="IMariDiscordRichGame" /> object.
    /// </summary>
    public interface IMariDiscordGameSecrets
    {
        /// <summary>
        /// The secret for a specific instanced match.
        /// </summary>
        string Match { get; }

        /// <summary>
        /// The secret for joining a party.
        /// </summary>
        string Join { get; }

        /// <summary>
        /// The secret for spectating a game.
        /// </summary>
        string Spectate { get; }
    }
}