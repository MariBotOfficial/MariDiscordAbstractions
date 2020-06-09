using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic direct-message channel.
    /// </summary>
    public interface IMariDiscordDMChannel : IMariDiscordPrivateChannel, IMariDiscordMessageChannel
    {
        /// <summary>
        /// Gets the recipient of all messages in this channel.
        /// </summary>
        IMariDiscordUser Recipient { get; }

        /// <summary>
        /// Closes this private channel, removing it from your channel list.
        /// </summary>
        Task<IMariDiscordRestResult> CloseAsync();
    }
}