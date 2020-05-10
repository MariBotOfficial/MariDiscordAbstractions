using System.Collections.Generic;

namespace MariBot.DiscordPatterns.Core.Models.Emotes
{
    /// <summary>
    /// Represents a custom image-based emote that is attached to a guild.
    /// </summary>
    public interface IMariDiscordGuildEmote : IMariDiscordCustomEmote
    {
        /// <summary>
        /// Whether this emoji is managed by an integration.
        /// </summary>
        bool IsManaged { get; }

        /// <summary>
        /// Whether this emoji must be wrapped in colons.
        /// </summary>
        bool RequireColons { get; }

        /// <summary>
        /// The roles that are allowed to use this emoji.
        /// </summary>
        IReadOnlyCollection<ulong> RoleIds { get; }

        /// <summary>
        /// The user ID associated with the creation of this emoji.
        /// </summary>
        ulong? CreatorId { get; }
    }
}