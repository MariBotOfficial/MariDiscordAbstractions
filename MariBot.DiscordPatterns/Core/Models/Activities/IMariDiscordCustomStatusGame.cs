using System;
using MariBot.DiscordPatterns.Core.Models.Emotes;

namespace MariBot.DiscordPatterns.Core.Models.Activities
{
    /// <summary>
    /// Represents a user's activity for their custom status.
    /// </summary>
    public interface IMariDiscordCustomStatusGame : IMariDiscordGame
    {
        /// <summary>
        /// The emote, if it is set.
        /// </summary>
        IMariDiscordEmote Emote { get; }

        /// <summary>
        /// The timestamp of when this status was created.
        /// </summary>
        DateTimeOffset CreatedAt { get; }

        /// <summary>
        /// The state of the status.
        /// </summary>
        string State { get; }
    }
}