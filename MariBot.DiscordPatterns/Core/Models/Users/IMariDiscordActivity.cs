namespace MariBot.DiscordPatterns.Core.Models.Users
{
    /// <summary>
    ///  Represents a user's activity status, typically a <see cref="MariDiscordGame"/>.
    /// </summary>
    public interface IMariDiscordActivity
    {
        /// <summary>
        /// The name of the activity.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The type of the activity.
        /// </summary>
        MariDiscordActivityType Type { get; }

        /// <summary>
        /// The flags that are relevant to this activity.
        /// </summary>
        MariDiscordActivityProperties Flags { get; }
        
        /// <summary>
        /// Gets the details on what the player is currently doing.
        /// </summary>
        string Details { get; }
    }
}