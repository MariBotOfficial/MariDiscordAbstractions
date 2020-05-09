namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents the source of the Discord message.
    /// </summary>
    public enum MariDiscordMessageSource
    {
        /// <summary>
        /// The message is sent by the system.
        /// </summary>
        System,

        /// <summary>
        /// The message is sent by a user.
        /// </summary>
        User,

        /// <summary>
        /// The message is sent by a bot.
        /// </summary>
        Bot,

        /// <summary>
        /// The message is sent by a webhook.
        /// </summary>
        Webhook
    }
}