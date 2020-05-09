namespace MariBot.DiscordPatterns.Core.Models.Users
{
    /// <summary>
    ///  Represents the types of clients a user can be active on.
    /// </summary>
    public enum MariDiscordClientType
    {
        /// <summary>
        /// The user is active using the mobile application.
        /// </summary>
        Mobile,
        /// <summary>
        /// The user is active using the desktop application.
        /// </summary>
        Desktop,
        /// <summary>
        /// The user is active using the web application.
        /// </summary>
        Web
    }
}