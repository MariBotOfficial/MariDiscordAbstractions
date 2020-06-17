namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Provides properties that are used to reorder an <see cref="IMariDiscordGuildChannel"/>.
    /// </summary>
    public class MariDiscordReorderChannelProperties
    {
        /// <summary>
        /// The ID of the channel to apply this position to.
        /// </summary>
        public ulong Id { get; }

        /// <summary>
        /// The new zero-based position of this channel.
        /// </summary>
        public int Position { get; set; }

        /// <summary> 
        /// Initializes a new instance of the <see cref="MariDiscordReorderChannelProperties"/> class used to reorder a channel. 
        /// </summary>
        /// <param name="id"> Sets the ID of the channel to apply this position to. </param>
        /// <param name="position"> Sets the new zero-based position of this channel. </param>
        public MariDiscordReorderChannelProperties(ulong id, int position)
        {
            Id = id;
            Position = position;
        }
    }
}