namespace MariBot.DiscordPatterns.Core.Models.Activities
{
    /// <summary>
    /// Represents a user's Rich Presence status.
    /// </summary>
    public interface IMariDiscordRichGame : IMariDiscordGame
    {
        /// <summary>
        /// The user's current party status.
        /// </summary>
        string State { get; }

        /// <summary>
        /// The application ID for the game.
        /// </summary>
        ulong ApplicationId { get; }

        /// <summary>
        /// The small image for the presence and their hover texts.
        /// </summary>
        IMariDiscordGameAsset SmallAsset { get; }

        /// <summary>
        /// The large image for the presence and their hover texts.
        /// </summary>
        IMariDiscordGameAsset LargeAsset { get; }

        /// <summary>
        /// The information for the current party of the player.
        /// </summary>
        IMariDiscordGameParty Party { get; }

        /// <summary>
        /// The secrets for Rich Presence joining and spectating.
        /// </summary>
        IMariDiscordGameSecrets Secrets { get; }

        /// <summary>
        /// The timestamps for start and/or end of the game.
        /// </summary>
        IMariDiscordGameTimestamps Timestamps { get; }
    }
}