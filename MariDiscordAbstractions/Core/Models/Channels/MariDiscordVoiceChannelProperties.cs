namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Provides properties that are used to modify an <see cref="IMariDiscordVoiceChannel" /> with the specified changes.
    /// </summary>
    public class MariDiscordVoiceChannelProperties : MariDiscordGuildChannelProperties
    {
        /// <summary>
        /// Gets or sets the bitrate of the voice connections in this channel. Must be greater than 8000.
        /// </summary>
        public MariDiscordOptional<int> BitRate { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of users that can be present in a channel, or <c>null</c> if none.
        /// </summary>
        public MariDiscordOptional<int?> UserLimit { get; set; }
    }
}