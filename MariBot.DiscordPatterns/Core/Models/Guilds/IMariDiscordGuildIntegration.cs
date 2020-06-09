using System;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Holds information for a guild integration feature.
    /// </summary>
    public interface IMariDiscordGuildIntegration
    {
        /// <summary>
        /// The integration ID.
        /// </summary>
        ulong Id { get; }

        /// <summary>
        /// The integration name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The integration type (Twitch, YouTube, etc).
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Indicates whether this integration is enabled or not.
        /// </summary>
        bool IsEnabled { get; }

        /// <summary>
        /// Indicates whether this integration is syncing or not.
        /// </summary>
        bool IsSyncing { get; }

        /// <summary>
        /// The ID that this integration uses for "subscribers".
        /// </summary>
        ulong ExpireBehavior { get; }

        /// <summary>
        /// The grace period before expiring "subscribers".
        /// </summary>
        ulong ExpireGracePeriod { get; }

        /// <summary>
        /// When this integration was last synced.
        /// </summary>
        DateTimeOffset SyncedAt { get; }

        /// <summary>
        /// Integration account information.
        /// </summary>
        IMariDiscordIntegrationAccount Account { get; }

        /// <summary>
        /// The guild of this integration.
        /// </summary>
        IMariDiscordGuild Guild { get; }

        /// <summary>
        /// The id of the guild of this integration.
        /// </summary>
        ulong GuildId => Guild.Id;

        /// <summary>
        /// Id that this integration uses for "subscribers"
        /// </summary>
        ulong RoleId { get; }

        /// <summary>
        /// user for this integration
        /// </summary>
        IMariDiscordUser User { get; }
    }
}