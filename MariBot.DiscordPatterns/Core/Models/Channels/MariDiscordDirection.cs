namespace MariBot.DiscordPatterns.Core.Models.Channels
{
    /// <summary>
    /// Specifies the direction of where message(s) should be retrieved from.
    /// </summary>
    public enum MariDiscordDirection
    {
        /// <summary>
        /// The message(s) should be retrieved before a message.
        /// </summary>
        Before,

        /// <summary>
        /// The message(s) should be retrieved after a message.
        /// </summary>
        After,

        /// <summary>
        /// The message(s) should be retrieved around a message.
        /// </summary>
        Around
    }
}