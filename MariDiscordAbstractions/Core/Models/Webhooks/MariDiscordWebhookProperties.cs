namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Properties used to modify an <see cref="IMariDiscordWebhook" /> with the specified changes.
    /// </summary>
    public class MariDiscordWebhookProperties
    {
        /// <summary>
        /// Gets or sets the default name of the webhook.
        /// </summary>
        public MariDiscordOptional<string> Name { get; set; }

        /// <summary>
        /// Gets or sets the default avatar of the webhook.
        /// </summary>
        public MariDiscordOptional<IMariDiscordImage> Image { get; set; }

        /// <summary>
        /// Gets or sets the channel for this webhook.
        /// </summary>
        public MariDiscordOptional<IMariDiscordTextChannel> Channel { get; set; }

        /// <summary>
        /// Gets or sets the channel ID for this webhook.
        /// </summary>
        public MariDiscordOptional<ulong> ChannelId { get; set; }
    }
}