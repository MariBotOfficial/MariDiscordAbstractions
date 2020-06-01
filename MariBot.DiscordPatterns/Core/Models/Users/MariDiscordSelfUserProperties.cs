namespace MariBot.DiscordPatterns.Core.Models.Users
{
    /// <summary>
    /// Properties that are used to modify the <see cref="IMariDiscordSelfUser" /> with the specified changes.
    /// </summary>
    public class MariDiscordSelfUserProperties
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the avatar.
        /// </summary>
        public IMariDiscordImage Avatar { get; set; }
    }
}