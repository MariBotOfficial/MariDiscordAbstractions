using System.Collections.Generic;
using MariBot.DiscordPatterns.Core.Models.Users;

namespace MariBot.DiscordPatterns.Core.Models.Channels
{
    /// <summary>
    /// Represents a generic channel that is private to select recipients.
    /// </summary>
    public interface IMariDiscordPrivateChannel : IMariDiscordChannel
    {
        /// <summary>
        /// Gets the users that can access this channel.
        /// </summary>
        IReadOnlyCollection<IMariDiscordUser> Recipients { get; }
    }
}