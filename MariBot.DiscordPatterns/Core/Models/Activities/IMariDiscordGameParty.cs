namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Party information for a <see cref="IMariDiscordRichGame" /> object.
    /// </summary>
    public interface IMariDiscordGameParty
    {
        /// <summary>
        /// The ID of the party.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// The party's current size.
        /// </summary>
        long Members { get; }

        /// <summary>
        /// the party's maximum size.
        /// </summary>
        long Capacity { get; }
    }
}