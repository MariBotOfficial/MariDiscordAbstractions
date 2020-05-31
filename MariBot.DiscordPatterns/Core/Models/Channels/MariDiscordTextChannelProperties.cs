using MariBot.DiscordPatterns.Core.Models.Permissions;

namespace MariBot.DiscordPatterns.Core.Models.Channels
{
    /// <summary>
    /// Provides properties that are used to modify an <see cref="IMariDiscordTextChannel"/> with the specified changes.
    /// </summary>
    public class MariDiscordTextChannelProperties : MariDiscordGuildChannelProperties
    {
        /// <summary>
        /// Gets or sets the topic of the channel.
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Gets or sets whether this channel should be flagged as NSFW.
        /// </summary>
        public bool? IsNsfw { get; set; }

        /// <summary>
        /// Gets or sets the slow-mode ratelimit in seconds for this channel.
        /// </summary>
        /// <note>
        /// Users with <see cref="MariDiscordChannelPermission.ManageMessages"/> or 
        /// <see cref="MariDiscordChannelPermission.ManageChannels"/> will be exempt from slow-mode.
        /// </note>
        public int? SlowModeInterval { get; set; }
    }
}