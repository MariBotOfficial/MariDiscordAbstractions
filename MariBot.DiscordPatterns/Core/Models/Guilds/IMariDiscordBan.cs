using MariBot.DiscordPatterns.Core.Models.Users;

namespace MariBot.DiscordPatterns.Core.Models.Guilds
{
    /// <summary>
    /// Represents a generic ban object.
    /// </summary>
    public interface IMariDiscordBan
    {
        /// <summary>
        /// The banned user.
        /// </summary>
        IMariDiscordUser User { get; }

        /// <summary>
        /// The reason why the user is banned if specified.
        /// </summary>
        string Reason { get; }
    }
}