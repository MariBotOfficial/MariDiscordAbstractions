using MariBot.DiscordPatterns.Core.Models.Channels;
using MariBot.DiscordPatterns.Core.Models.Guilds;

namespace MariBot.DiscordPatterns.Core.Models.Invites
{
    /// <summary>
    /// Represents a generic invite object.
    /// </summary>
    public interface IMariDiscordInvite : IMariDiscordEntity<string>, IMariDiscordDeletable
    {
        /// <summary>
        /// The unique identifier for this invite.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// The URL used to accept this invite using <see cref="Code"/>.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// The channel this invite is linked to.
        /// </summary>
        IMariDiscordChannel Channel { get; }

        /// <summary>
        /// The guild this invite is linked to.
        /// </summary>
        IMariDiscordGuild Guild { get; }

        /// <summary>
        /// The approximated count of online members in the guild.
        /// </summary>
        int? PresenceCount { get; }

        /// <summary>
        /// The approximated count of total members in the guild.
        /// </summary>
        int? MemberCount { get; }
    }
}