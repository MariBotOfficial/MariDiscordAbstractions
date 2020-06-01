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
        public MariDiscordOptional<bool> Enabled { get; set; }

        /// <summary>
        /// Gets or sets the channel that the invite should place its users in, if not <c>null</c>.
        /// </summary>
        public MariDiscordOptional<IMariDiscordChannel> Channel { get; set; }

        /// <summary>
        /// Gets or sets the channel the invite should place its users in, if not <c>null</c>.
        /// </summary>
        public MariDiscordOptional<ulong?> ChannelId { get; set; }
    }
}