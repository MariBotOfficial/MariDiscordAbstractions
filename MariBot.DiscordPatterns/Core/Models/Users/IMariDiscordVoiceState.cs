using MariBot.DiscordPatterns.Core.Models.Channels;

namespace MariBot.DiscordPatterns.Core.Models.Users
{
    /// <summary>
    /// Represents a user's voice connection status.
    /// </summary>
    public interface IMariDiscordVoiceState
    {
        /// <summary>
        /// A value that indicates whether this user is deafened by the guild.
        /// </summary>
        bool IsDeafened { get; }

        /// <summary>
        /// A value that indicates whether this user is muted (i.e. not permitted to speak via voice) by the
        /// guild.
        /// </summary>
        bool IsMuted { get; }

        /// <summary>
        /// A value that indicates whether this user has marked themselves as deafened.
        /// </summary>
        bool IsSelfDeafened { get; }

        /// <summary>
        /// A value that indicates whether this user has marked themselves as muted (i.e. not permitted to
        /// speak via voice).
        /// </summary>
        bool IsSelfMuted { get; }

        /// <summary>
        /// A value that indicates whether the user is muted by the current user.
        /// </summary>
        bool IsSuppressed { get; }

        /// <summary>
        /// The voice channel this user is currently in.
        /// </summary>
        IMariDiscordVoiceChannel VoiceChannel { get; }

        /// <summary>
        /// The unique identifier for this user's voice session.
        /// </summary>
        string VoiceSessionId { get; }

        /// <summary>
        /// A value that indicates if this user is streaming in a voice channel.
        /// </summary>
        bool IsStreaming { get; }
    }
}