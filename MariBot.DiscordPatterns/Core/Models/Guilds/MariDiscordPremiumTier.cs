namespace MariBot.DiscordPatterns.Core.Models.Guilds
{
    /// <summary>
    /// Boost tier of this guild.
    /// </summary>
    public enum MariDiscordPremiumTier
    {
        /// <summary>
        /// Used for guilds that have no guild boosts.
        /// </summary>
        None = 0,

        /// <summary>
        /// Used for guilds that have Tier 1 guild boosts.
        /// </summary>
        Tier1 = 1,

        /// <summary>
        /// Used for guilds that have Tier 2 guild boosts.
        /// </summary>
        Tier2 = 2,

        /// <summary>
        /// Used for guilds that have Tier 3 guild boosts.
        /// </summary>
        Tier3 = 3,
    }
}