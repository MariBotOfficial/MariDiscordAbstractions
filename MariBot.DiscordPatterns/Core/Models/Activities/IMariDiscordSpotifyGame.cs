using System;
using System.Collections.Generic;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a user's activity for listening to a song on Spotify.
    /// </summary>
    public interface IMariDiscordSpotifyGame : IMariDiscordGame
    {
        /// <summary>
        /// The song's artist(s).
        /// </summary>
        IReadOnlyCollection<string> Artists { get; }

        /// <summary>
        /// The Spotify album title of the song.
        /// </summary>
        string AlbumTitle { get; }

        /// <summary>
        /// The track title of the song.
        /// </summary>
        string TrackTitle { get; }

        /// <summary>
        /// The date when the track started playing.
        /// </summary>
        DateTimeOffset? StartedAt { get; }

        /// <summary>
        /// The date when the track ends.
        /// </summary>
        DateTimeOffset? EndsAt { get; }

        /// <summary>
        /// The duration of the song.
        /// </summary>
        TimeSpan? Duration { get; }

        /// <summary>
        /// The elapsed duration of the song.
        /// </summary>
        TimeSpan? Elapsed => DateTimeOffset.UtcNow - StartedAt;

        /// <summary>
        /// The remaining duration of the song.
        /// </summary>
        TimeSpan? Remaining => EndsAt - DateTimeOffset.UtcNow;

        /// <summary>
        /// The track ID of the song.
        /// </summary>
        string TrackId { get; }

        /// <summary>
        /// The session ID of the song.
        /// </summary>
        string SessionId { get; }

        /// <summary>
        /// The URL of the album art.
        /// </summary>
        string AlbumArtUrl { get; }

        /// <summary>
        /// The direct Spotify URL of the track.
        /// </summary>
        string TrackUrl { get; }
    }
}