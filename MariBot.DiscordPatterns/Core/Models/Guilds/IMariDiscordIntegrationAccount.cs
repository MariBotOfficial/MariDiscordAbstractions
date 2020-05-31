namespace MariBot.DiscordPatterns.Core.Models.Guilds
{
    /// <summary>
    /// Integration account information
    /// </summary>
    public interface IMariDiscordIntegrationAccount
    {
        /// <summary>
        /// The ID of the account.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        string Name { get; }
    }
}