namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic ban object.
    /// </summary>
    public interface IMariDiscordBan
    {
        /// <summary>
        /// The banned user.
        /// </summary>
        IMariDiscordUser User { get; }

        /// <summary>
        /// The reason why the user is banned if specified.
        /// </summary>
        string Reason { get; }
    }
}