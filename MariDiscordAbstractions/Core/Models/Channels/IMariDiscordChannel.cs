using System.Collections.Generic;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a Discord's channel.
    /// </summary>
    public interface IMariDiscordChannel : IMariDiscordSnowFlakeEntity
    {

        /// <summary>
        /// The name of this channel.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets a collection of users that are able to view the channel or are currently in this channel.
        /// </summary>
        IAsyncEnumerable<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordUser>>> GetUsersAsync();

        /// <summary>
        /// Gets a user in this channel.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordUser>> GetUserAsync(ulong id);
    }
}