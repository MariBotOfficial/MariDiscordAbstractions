using System;
using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Channels;
using MariBot.DiscordPatterns.Core.Models.Guilds;
using MariBot.DiscordPatterns.Core.Models.Users;

namespace MariBot.DiscordPatterns.Core.Models.Webhooks
{
    /// <summary>
    /// Represents a webhook object on Discord.
    /// </summary>
    public interface IMariDiscordWebhook : IMariDiscordDeletable, IMariDiscordSnowFlakeEntity
    {
        /// <summary>
        /// The token of this webhook.
        /// </summary>
        string Token { get; }

        /// <summary>
        /// The default name of this webhook.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The ID of this webhook's default avatar.
        /// </summary>
        string AvatarId { get; }

        /// <summary>
        /// The URL to this webhook's default avatar.
        /// </summary>
        string GetAvatarUrl(MariDiscordImageFormat format = MariDiscordImageFormat.Auto, ushort size = 128);

        /// <summary>
        /// The channel for this webhook.
        /// </summary>
        IMariDiscordTextChannel Channel { get; }

        /// <summary>
        /// The ID of the channel for this webhook.
        /// </summary>
        ulong ChannelId { get; }

        /// <summary>
        /// The guild owning this webhook.
        /// </summary>
        IMariDiscordGuild Guild { get; }

        /// <summary>
        /// The ID of the guild owning this webhook.
        /// </summary>
        ulong? GuildId { get; }

        /// <summary>
        /// The user that created this webhook.
        /// </summary>
        IMariDiscordUser Creator { get; }

        /// <summary>
        /// Modifies this webhook.
        /// </summary>
        Task ModifyAsync(Action<MariDiscordWebhookProperties> func);
    }
}