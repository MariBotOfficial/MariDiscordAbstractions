namespace MariBot.DiscordPatterns
{
    /// <summary>
    ///  Represents a metadata containing reaction information.
    /// </summary>
    public interface IMariDiscordReactionMetadata
    {
        /// <summary>
        /// The number of reactions.
        /// </summary>
        int ReactionCount { get; }

        /// <summary>
        /// Represents a value that indicates whether the current user has reacted to this.
        /// </summary>
        bool IsMe { get; }
    }
}