using MariBot.DiscordPatterns.Core.Models.Channels;

namespace MariBot.DiscordPatterns.Core.Models.Guilds
{
    /// <summary>
    /// Provides properties that are used to modify the widget of an <see cref="IMariDiscordGuild" /> with the specified changes.
    /// </summary>
    public class MariDiscordGuildEmbedProperties
    {
        /// <summary>
        /// Gets or sets whether the widget should be enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the channel that the invite should place its users in, if not <c>null</c>.
        /// </summary>
        public IMariDiscordChannel Channel { get; set; }

        /// <summary>
        /// Gets or sets the channel the invite should place its users in, if not <c>null</c>.
        /// </summary>
        public ulong? ChannelId { get; set; }
    }
}