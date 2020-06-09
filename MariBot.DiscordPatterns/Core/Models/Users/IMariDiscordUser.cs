using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic user.
    /// </summary>
    public interface IMariDiscordUser : IMariDiscordSnowFlakeEntity, IMariDiscordPresence, IMariDiscordMentionable
    {
        /// <summary>
        /// The identifier of this user's avatar.
        /// </summary>
        string AvatarId { get; }

        /// <summary>
        /// The avatar URL for this user.
        /// </summary>
        string GetAvatarUrl(MariDiscordImageFormat format = MariDiscordImageFormat.Auto, ushort size = 128);

        /// <summary>
        /// The default avatar URL for this user.
        /// </summary>
        string GetDefaultAvatarUrl();

        /// <summary>
        /// The per-username unique ID for this user.
        /// </summary>
        string Discriminator { get; }


        /// <summary>
        /// The per-username unique ID for this user.
        /// </summary>
        ushort DiscriminatorValue { get; }

        /// <summary>
        /// Represents whether this user is identified as a bot.
        /// </summary>
        bool IsBot { get; }

        /// <summary>
        /// Represents whether this user is a webhook user.
        /// </summary>
        bool IsWebhook { get; }

        /// <summary>
        /// The username for this user.
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Gets the direct message channel of this user, or create one if it does not already exist.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordDMChannel>> GetOrCreateDMChannelAsync();
    }
}