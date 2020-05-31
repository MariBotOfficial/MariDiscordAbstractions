using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Results;

namespace MariBot.DiscordPatterns.Core.Models.Channels
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