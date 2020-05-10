namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Contains the IDs sent from a crossposted message.
    /// </summary>
    public interface IMariDiscordMessageReference
    {
        /// <summary>
        /// The Message ID of the original message.
        /// </summary>
        ulong? MessageId { get; }

        /// <summary>
        /// The Channel ID of the original message.
        /// </summary>
        ulong ChannelId { get; }

        /// <summary>
        /// The Guild ID of the original message.
        /// </summary>
        ulong? GuildId { get; }
    }
}