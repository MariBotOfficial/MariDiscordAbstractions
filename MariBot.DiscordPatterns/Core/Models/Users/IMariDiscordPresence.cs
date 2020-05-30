using System.Collections.Generic;
using MariBot.DiscordPatterns.Core.Models.Activities;

namespace MariBot.DiscordPatterns.Core.Models.Users
{
    /// <summary>
    /// Represents the user's presence status. This may include their online status and their activity.
    /// </summary>
    public interface IMariDiscordPresence
    {
        /// <summary>
        /// The activity this user is currently doing.
        /// </summary>
        IMariDiscordActivity Activity { get; }

        /// <summary>
        /// The current status of this user.
        /// </summary>
        MariDiscordUserStatus Status { get; }

        /// <summary>
        /// The set of clients where this user is currently active.
        /// </summary>
        IReadOnlyCollection<MariDiscordClientType> ActiveClients { get; }
    }
}