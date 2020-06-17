namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a discord entity.
    /// </summary>
    public interface IMariDiscordEntity<TId>
    {
        /// <summary>
        /// Gets the unique discord identifier for this object.
        /// </summary>
        TId Id { get; }
    }
}