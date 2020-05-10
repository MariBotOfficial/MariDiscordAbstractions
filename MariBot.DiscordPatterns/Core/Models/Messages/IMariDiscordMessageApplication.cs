namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents an application object found in a sent message.
    /// </summary>
    public interface IMariDiscordMessageApplication : IMariDiscordSnowFlakeEntity
    {
        /// <summary>
        /// The ID of the embed's image asset.
        /// </summary>
        string CoverImage { get; }

        /// <summary>
        /// The application's description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The ID of the application's icon.
        /// </summary>
        string Icon { get; }

        /// <summary>
        /// The Url of the application's icon.
        /// </summary>
        string IconUrl { get; }

        /// <summary>
        /// The name of the application.
        /// </summary>
        string Name { get; }
    }
}