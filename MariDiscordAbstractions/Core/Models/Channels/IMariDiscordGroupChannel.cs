using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic private group channel.
    /// </summary>
    public interface IMariDiscordGroupChannel : IMariDiscordMessageChannel, IMariDiscordPrivateChannel
    {
        /// <summary>
        /// Leaves this group.
        /// </summary>
        Task<IMariDiscordRestResult> LeaveAsync();
    }
}