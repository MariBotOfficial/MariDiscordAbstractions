namespace MariBot.DiscordPatterns.Core.Models.Guilds
{
    /// <summary>
    /// Specifies the guild's Multi-Factor Authentication (MFA) level requirement.
    /// </summary>
    public enum MariDiscordMfaLevel
    {
        /// <summary>
        /// Users have no additional MFA restriction on this guild.
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Users must have MFA enabled on their account to perform administrative actions.
        /// </summary>
        Enabled = 1
    }
}