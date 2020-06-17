namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a user's activity for streaming on services such as Twitch.
    /// </summary>
    public interface IMariDiscordStreamingGame : IMariDiscordGame
    {
        /// <summary>
        /// The URL of the stream.
        /// </summary>
        string Url { get; }
    }
}