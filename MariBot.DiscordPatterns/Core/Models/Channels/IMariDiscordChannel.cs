using System.Collections.Generic;
using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Results;
using MariBot.DiscordPatterns.Core.Models.Users;

namespace MariBot.DiscordPatterns.Core.Models.Channels
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
        IAsyncEnumerable<IReadOnlyCollection<IMariDiscordUser>> GetUsersAsync();

        /// <summary>
        /// Gets a user in this channel.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordUser>> GetUserAsync(ulong id);
    }
}