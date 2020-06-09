using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a Discord's message.
    /// </summary>
    public interface IMariDiscordMessage : IMariDiscordSnowFlakeEntity, IMariDiscordDeletable
    {
        /// <summary>
        /// The type of this system message.
        /// </summary>
        MariDiscordMessageType Type { get; }

        /// <summary>
        /// The source type of this message.
        /// </summary>
        MariDiscordMessageSource Source { get; }

        /// <summary>
        /// The value that indicates whether this message was meant to be read-aloud by Discord.
        /// </summary>
        bool IsTTS { get; }

        /// <summary>
        /// The value that indicates whether this message is pinned.
        /// </summary>
        bool IsPinned { get; }

        /// <summary>
        /// The value that indicates whether or not this message's embeds are suppressed.
        /// </summary>
        bool IsSuppressed { get; }

        /// <summary>
        /// The content for this message.
        /// </summary>
        string Content { get; }

        /// <summary>
        /// The time this message was sent.
        /// </summary>
        DateTimeOffset Timestamp { get; }

        /// <summary>
        /// The time of this message's last edit.
        /// </summary>
        DateTimeOffset? EditedTimestamp { get; }

        /// <summary>
        /// The source channel of the message.
        /// </summary>
        IMariDiscordMessageChannel Channel { get; }

        /// <summary>
        /// The author of this message.
        /// </summary>
        IMariDiscordUser Author { get; }

        /// <summary>
        /// All attachments included in this message.
        /// </summary>
        IReadOnlyCollection<IMariDiscordAttachment> Attachments { get; }

        /// <summary>
        /// All embeds included in this message.
        /// </summary>
        IReadOnlyCollection<IMariDiscordEmbed> Embeds { get; }

        /// <summary>
        /// All tags included in this message's content.
        /// </summary>
        IReadOnlyCollection<IMariDiscordTag> Tags { get; }

        /// <summary>
        /// The IDs of channels mentioned in this message.
        /// </summary>
        IReadOnlyCollection<ulong> MentionedChannelIds { get; }

        /// <summary>
        /// The IDs of roles mentioned in this message.
        /// </summary>
        IReadOnlyCollection<ulong> MentionedRoleIds { get; }

        /// <summary>
        /// The IDs of users mentioned in this message.
        /// </summary>
        IReadOnlyCollection<ulong> MentionedUserIds { get; }

        /// <summary>
        /// The activity associated with a message.
        /// </summary>
        IMariDiscordMessageActivity Activity { get; }

        /// <summary>
        /// The application associated with a message.
        /// </summary>
        IMariDiscordMessageApplication Application { get; }


        /// <summary>
        /// The reference to the original message if it was crossposted.
        /// </summary>
        IMariDiscordMessageReference Reference { get; }


        /// <summary>
        ///     Gets all reactions included in this message.
        /// </summary>
        IReadOnlyDictionary<IMariDiscordEmote, IMariDiscordReactionMetadata> Reactions { get; }


        /// <summary>
        /// Adds a reaction to this message.
        /// </summary>
        Task<IMariDiscordRestResult> AddReactionAsync(IMariDiscordEmote emote);

        /// <summary>
        /// Removes a reaction from message.
        /// </summary>
        Task<IMariDiscordRestResult> RemoveReactionAsync(IMariDiscordEmote emote, IMariDiscordUser user);

        /// <summary>
        /// Removes a reaction from message.
        /// </summary>
        Task<IMariDiscordRestResult> RemoveReactionAsync(IMariDiscordEmote emote, ulong userId);

        /// <summary>
        /// Removes all reactions from this message.
        /// </summary>
        Task<IMariDiscordRestResult> RemoveAllReactionsAsync();

        /// <summary>
        /// Gets all users that reacted to a message with a given emote.
        /// </summary>
        IAsyncEnumerable<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordUser>>> GetReactionUsersAsync(IMariDiscordEmote emoji, int limit);
    }
}