namespace MariBot.DiscordPatterns.Core.Models.Channels
{
    /// <summary>
    /// Properties that are used to modify an <see cref="IMariDiscordGuildChannel" /> with the specified changes.
    /// </summary>
    public class MariDiscordGuildChannelProperties
    {
        /// <summary>
        /// Gets or sets the channel to this name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Moves the channel to the following position. This property is zero-based.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets the category ID for this channel.
        /// </summary>
        public ulong? CategoryId { get; set; }
    }
}