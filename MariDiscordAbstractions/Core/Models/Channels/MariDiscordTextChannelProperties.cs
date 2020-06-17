namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Provides properties that are used to modify an <see cref="IMariDiscordTextChannel"/> with the specified changes.
    /// </summary>
    public class MariDiscordTextChannelProperties : MariDiscordGuildChannelProperties
    {
        /// <summary>
        /// Gets or sets the topic of the channel.
        /// </summary>
        public MariDiscordOptional<string> Topic { get; set; }

        /// <summary>
        /// Gets or sets whether this channel should be flagged as NSFW.
        /// </summary>
        public MariDiscordOptional<bool> IsNsfw { get; set; }

        /// <summary>
        /// Gets or sets the slow-mode ratelimit in seconds for this channel.
        /// </summary>
        /// <note>
        /// Users with <see cref="MariDiscordChannelPermission.ManageMessages"/> or 
        /// <see cref="MariDiscordChannelPermission.ManageChannels"/> will be exempt from slow-mode.
        /// </note>
        public MariDiscordOptional<int> SlowModeInterval { get; set; }
    }
}