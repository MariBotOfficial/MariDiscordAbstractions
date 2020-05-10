namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents an activity object found in a sent message.
    /// </summary>
    public interface IMariDiscordMessageActivity
    {
        /// <summary>
        /// The type of activity of this message.
        /// </summary>
        MariDiscordMessageActivityType Type { get; }

        /// <summary>
        /// The party ID of this activity, if any.
        /// </summary>
        string PartyId { get; }
    }
}