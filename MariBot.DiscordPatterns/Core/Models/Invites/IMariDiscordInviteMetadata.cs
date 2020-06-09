using System;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents additional information regarding the generic invite object.
    /// </summary>
    public interface IMariDiscordInviteMetadata : IMariDiscordInvite
    {
        /// <summary>
        /// The user that created this invite.
        /// </summary>
        IMariDiscordUser Inviter { get; }

        /// <summary>
        /// Indicates whether the invite has been revoked.
        /// </summary>
        bool IsRevoked { get; }

        /// <summary>
        /// Indicates whether the invite is a temporary one.
        /// </summary>
        bool IsTemporary { get; }

        /// <summary>
        /// The time (in seconds) until the invite expires.
        /// </summary>
        int? MaxAge { get; }

        /// <summary>
        /// The max number of uses this invite may have.
        /// </summary>
        int? MaxUses { get; }

        /// <summary>
        /// The number of times this invite has been used.
        /// </summary>
        int? Uses { get; }

        /// <summary>
        /// When this invite was created.
        /// </summary>
        DateTimeOffset? CreatedAt { get; }
    }
}