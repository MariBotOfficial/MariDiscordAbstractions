namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents the type of <see cref="IMariDiscordMessageActivity" />.
    /// </summary>
    public enum MariDiscordMessageActivityType
    {
        /// <summary>
        /// The type is for join.
        /// </summary>
        Join = 1,

        /// <summary>
        /// The type is for spectate.
        /// </summary>
        Spectate = 2,

        /// <summary>
        /// The type is for listen.
        /// </summary>
        Listen = 3,

        /// <summary>
        /// The type is a join request.
        /// </summary>
        JoinRequest = 5
    }
}