using MariBot.DiscordPatterns.Core.Models.Channels;

namespace MariBot.DiscordPatterns.Core.Models.Webhooks
{
    /// <summary>
    /// Properties used to modify an <see cref="IMariDiscordWebhook" /> with the specified changes.
    /// </summary>
    public class MariDiscordWebhookProperties
    {
        /// <summary>
        /// Gets or sets the default name of the webhook.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the default avatar of the webhook.
        /// </summary>
        public IMariDiscordImage Image { get; set; }

        /// <summary>
        /// Gets or sets the channel for this webhook.
        /// </summary>
        public IMariDiscordTextChannel Channel { get; set; }

        /// <summary>
        /// Gets or sets the channel ID for this webhook.
        /// </summary>
        public ulong? ChannelId { get; set; }
    }
}