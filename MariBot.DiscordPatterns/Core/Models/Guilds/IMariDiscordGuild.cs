using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic guild/server.
    /// </summary>
    public interface IMariDiscordGuild : IMariDiscordDeletable, IMariDiscordSnowFlakeEntity
    {
        /// <summary>
        /// The name of this guild.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The amount of time (in seconds) a user must be inactive in a voice channel for until they are
        /// automatically moved to the AFK voice channel.
        /// </summary>
        int AFKTimeout { get; }

        /// <summary>
        /// Indicates whether this guild is embeddable (i.e. can use widget).
        /// </summary>
        bool IsEmbeddable { get; }

        /// <summary>
        /// The default message notifications for users who haven't explicitly set their notification settings.
        /// </summary>
        MariDiscordDefaultMessageNotifications DefaultMessageNotifications { get; }

        /// <summary>
        /// The level of Multi-Factor Authentication requirements a user must fulfill before being allowed to
        /// perform administrative actions in this guild.
        /// </summary>
        MariDiscordMfaLevel MfaLevel { get; }

        /// <summary>
        /// The level of requirements a user must fulfill before being allowed to post messages in this guild.
        /// </summary>
        MariDiscordVerificationLevel VerificationLevel { get; }

        /// <summary>
        /// The level of content filtering applied to user's content in a Guild.
        /// </summary>
        MariDiscordExplicitContentFilterLevel ExplicitContentFilter { get; }

        /// <summary>
        /// The ID of this guild's icon.
        /// </summary>
        string IconId { get; }

        /// <summary>
        /// The URL of this guild's icon.
        /// </summary>
        string IconUrl { get; }

        /// <summary>
        /// The ID of this guild's splash image.
        /// </summary>
        string SplashId { get; }

        /// <summary>
        /// The URL of this guild's splash image.
        /// </summary>
        string SplashUrl { get; }

        /// <summary>
        /// Determines if this guild is currently connected and ready to be used.
        /// </summary>
        bool Available { get; }


        /// <summary>
        /// The ID of the AFK voice channel for this guild.
        /// </summary>
        ulong? AFKChannelId { get; }

        /// <summary>
        /// The ID of the default channel for this guild.
        /// </summary>
        ulong DefaultChannelId { get; }

        /// <summary>
        /// The ID of the widget embed channel of this guild.
        /// </summary>
        ulong? EmbedChannelId { get; }

        /// <summary>
        /// The ID of the channel where randomized welcome messages are sent.
        /// </summary>
        ulong? SystemChannelId { get; }

        /// <summary>
        /// The ID of the user that owns this guild.
        /// </summary>
        ulong OwnerId { get; }

        /// <summary>
        /// The application ID of the guild creator if it is bot-created.
        /// </summary>
        ulong? ApplicationId { get; }

        /// <summary>
        /// The ID of the region hosting this guild's voice channels.
        /// </summary>
        string VoiceRegionId { get; }

        /// <summary>
        /// The built-in role containing all users in this guild.
        /// </summary>
        IMariDiscordRole EveryoneRole { get; }

        /// <summary>
        /// All custom emotes for this guild.
        /// </summary>
        IReadOnlyCollection<IMariDiscordGuildEmote> Emotes { get; }

        /// <summary>
        /// All extra features added to this guild.
        /// </summary>
        IReadOnlyCollection<string> Features { get; }

        /// <summary>
        /// All roles in this guild.
        /// </summary>
        IReadOnlyCollection<IMariDiscordRole> Roles { get; }

        /// <summary>
        /// The tier of guild boosting in this guild.
        /// </summary>
        MariDiscordPremiumTier PremiumTier { get; }

        /// <summary>
        /// The identifier for this guilds banner image.
        /// </summary>
        string BannerId { get; }

        /// <summary>
        /// The URL of this guild's banner image.
        /// </summary>
        string BannerUrl { get; }

        /// <summary>
        /// The code for this guild's vanity invite URL.
        /// </summary>
        string VanityURLCode { get; }

        /// <summary>
        /// The flags for the types of system channel messages that are disabled.
        /// </summary>
        MariDiscordSystemChannelMessageDeny SystemChannelFlags { get; }

        /// <summary>
        /// The description for the guild.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The number of premium subscribers of this guild.
        /// </summary>
        int PremiumSubscriptionCount { get; }


        /// <summary>
        /// The preferred locale of this guild in IETF BCP 47
        /// language tag format.
        /// </summary>
        string PreferredLocale { get; }


        /// <summary>
        /// The preferred culture of this guild.
        /// </summary>
        CultureInfo PreferredCulture { get; }


        /// <summary>
        /// Modifies this guild.
        /// </summary>
        /// <param name="func">The delegate containing the properties to modify the guild with.</param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordGuildProperties> func);

        /// <summary>
        /// Modifies this guild's embed channel.
        /// </summary>
        /// <param name="func">The delegate containing the properties to modify the guild widget with.</param>
        Task<IMariDiscordRestResult> ModifyEmbedAsync(Action<MariDiscordGuildEmbedProperties> func);

        /// <summary>
        /// Bulk-modifies the order of channels in this guild.
        /// </summary>
        /// <param name="args">The properties used to modify the channel positions with.</param>
        Task<IMariDiscordRestResult> ReorderChannelsAsync(IEnumerable<MariDiscordReorderChannelProperties> args);

        /// <summary>
        /// Bulk-modifies the order of roles in this guild.
        /// </summary>
        /// <param name="args">The properties used to modify the role positions with.</param>
        Task<IMariDiscordRestResult> ReorderRolesAsync(IEnumerable<MariDiscordReorderRoleProperties> args);

        /// <summary>
        /// Leaves this guild.
        /// </summary>
        Task<IMariDiscordRestResult> LeaveAsync();

        /// <summary>
        /// Gets a collection of all users banned in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordBan>>> GetBansAsync();

        /// <summary>
        /// Gets a ban object for a banned user.
        /// </summary>
        /// <param name="user">The banned user.</param>
        Task<IMariDiscordRestResult<IMariDiscordBan>> GetBanAsync(IMariDiscordUser user)
            => GetBanAsync(user.Id);

        /// <summary>
        /// Gets a ban object for a banned user.
        /// </summary>
        /// <param name="userId">The snowflake identifier for the banned user.</param>
        Task<IMariDiscordRestResult<IMariDiscordBan>> GetBanAsync(ulong userId);

        /// <summary>
        /// Bans the user from this guild and optionally prunes their recent messages.
        /// </summary>
        /// <param name="user">The user to ban.</param>
        /// <param name="pruneDays">The number of days to remove messages from this user for, and this number must be between [0, 7].</param>
        /// <param name="reason">The reason of the ban to be written in the audit log.</param>
        Task<IMariDiscordRestResult> AddBanAsync(IMariDiscordUser user, int pruneDays = 0, string reason = null);

        /// <summary>
        /// Bans the user from this guild and optionally prunes their recent messages.
        /// </summary>
        /// <param name="userId">The snowflake ID of the user to ban.</param>
        /// <param name="pruneDays">The number of days to remove messages from this user for, and this number must be between [0, 7].</param>
        /// <param name="reason">The reason of the ban to be written in the audit log.</param>
        Task<IMariDiscordRestResult> AddBanAsync(ulong userId, int pruneDays = 0, string reason = null);

        /// <summary>
        /// Unbans the user if they are currently banned.
        /// </summary>
        /// <param name="user">The user to be unbanned.</param>
        Task<IMariDiscordRestResult> RemoveBanAsync(IMariDiscordUser user)
            => RemoveBanAsync(user.Id);

        /// <summary>
        /// Unbans the user if they are currently banned.
        /// </summary>
        /// <param name="userId">The snowflake identifier of the user to be unbanned.</param>
        Task<IMariDiscordRestResult> RemoveBanAsync(ulong userId);

        /// <summary>
        /// Gets a collection of all channels in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordGuildChannel>>> GetChannelsAsync();

        /// <summary>
        /// Gets a channel in this guild.
        /// </summary>
        /// <param name="id">The snowflake identifier for the channel.</param>
        Task<IMariDiscordRestResult<IMariDiscordGuildChannel>> GetChannelAsync(ulong id);

        /// <summary>
        /// Gets a collection of all text channels in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordTextChannel>>> GetTextChannelsAsync();

        /// <summary>
        /// Gets a text channel in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordTextChannel>> GetTextChannelAsync(ulong id);

        /// <summary>
        /// Gets a collection of all voice channels in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordVoiceChannel>>> GetVoiceChannelsAsync();

        /// <summary>
        /// Gets a collection of all category channels in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordCategoryChannel>>> GetCategoriesAsync();

        /// <summary>
        /// Gets a voice channel in this guild.
        /// </summary>
        /// <param name="id">The snowflake identifier for the voice channel.</param>
        Task<IMariDiscordRestResult<IMariDiscordVoiceChannel>> GetVoiceChannelAsync(ulong id);

        /// <summary>
        /// The AFK voice channel in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordVoiceChannel>> GetAFKChannelAsync();

        /// <summary>
        /// The system channel where randomized welcome messages are sent in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordTextChannel>> GetSystemChannelAsync();

        /// <summary>
        /// The first viewable text channel in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordTextChannel>> GetDefaultChannelAsync();

        /// <summary>
        /// The embed channel (i.e. the channel set in the guild's widget settings) in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordGuildChannel>> GetEmbedChannelAsync();

        /// <summary>
        /// Creates a new text channel in this guild.
        /// </summary>
        /// <param name="name">The new name for the text channel.</param>
        /// <param name="func">The delegate containing the properties to be applied to the channel upon its creation.</param>
        Task<IMariDiscordRestResult<IMariDiscordTextChannel>> CreateTextChannelAsync(string name, Action<MariDiscordTextChannelProperties> func = null);

        /// <summary>
        /// Creates a new voice channel in this guild.
        /// </summary>
        /// <param name="name">The new name for the voice channel.</param>
        /// <param name="func">The delegate containing the properties to be applied to the channel upon its creation.</param>
        Task<IMariDiscordRestResult<IMariDiscordVoiceChannel>> CreateVoiceChannelAsync(string name, Action<MariDiscordVoiceChannelProperties> func = null);

        /// <summary>
        /// Creates a new channel category in this guild.
        /// </summary>
        /// <param name="name">The new name for the category.</param>
        /// <param name="func">The delegate containing the properties to be applied to the channel upon its creation.</param>
        Task<IMariDiscordRestResult<IMariDiscordCategoryChannel>> CreateCategoryAsync(string name, Action<MariDiscordGuildChannelProperties> func = null);

        /// <summary>
        /// Gets a collection of all the voice regions this guild can access.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordVoiceRegion>>> GetVoiceRegionsAsync();

        /// <summary>
        /// Get a collection of all integrations in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordGuildIntegration>>> GetIntegrationsAsync();

        /// <summary>
        /// Create a integration in this guild.
        /// </summary>
        /// <param name="id">The id of the integration.</param>
        /// <param name="type">The type of the integration.</param>
        Task<IMariDiscordRestResult<IMariDiscordGuildIntegration>> CreateIntegrationAsync(ulong id, string type);

        /// <summary>
        /// Gets a collection of all invites in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordInviteMetadata>>> GetInvitesAsync();

        /// <summary>
        /// The vanity invite URL of this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordInviteMetadata>> GetVanityInviteAsync();

        /// <summary>
        /// Gets a role in this guild.
        /// </summary>
        /// <param name="id">The snowflake identifier for the role.</param>
        IMariDiscordRole GetRole(ulong id);

        /// <summary>
        /// Creates a new role with the provided name.
        /// </summary>
        /// <param name="name">The new name for the role.</param>
        /// <param name="permissions">The guild permission that the role should possess.</param>
        /// <param name="color">The color of the role.</param>
        /// <param name="isHoisted">Whether the role is separated from others on the sidebar.</param>
        Task<IMariDiscordRestResult<IMariDiscordRole>> CreateRoleAsync(string name, IMariDiscordGuildPermissions permissions = null, IMariDiscordColor color = null, bool isHoisted = false);

        /// <summary>
        /// Adds a user to this guild.
        /// </summary>
        /// <remarks>
        /// This method requires you have an OAuth2 access token for the user, requested with the guilds.join scope, and that the bot have the MANAGE_INVITES permission in the guild.
        /// </remarks>
        /// <param name="userId">The snowflake identifier of the user.</param>
        /// <param name="accessToken">The OAuth2 access token for the user, requested with the guilds.join scope.</param>
        /// <param name="func">The delegate containing the properties to be applied to the user upon being added to the guild.</param>
        Task<IMariDiscordRestResult<IMariDiscordGuildUser>> AddGuildUserAsync(ulong userId, string accessToken, Action<MariDiscordAddGuildUserProperties> func = null);

        /// <summary>
        /// Gets a collection of all users in this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordGuildUser>>> GetUsersAsync();

        /// <summary>
        /// Gets a user from this guild.
        /// </summary>
        /// <param name="id">The snowflake identifier of the user.</param>
        Task<IMariDiscordRestResult<IMariDiscordGuildUser>> GetUserAsync(ulong id);

        /// <summary>
        /// The current user for this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordGuildUser>> GetCurrentUserAsync();

        /// <summary>
        /// The owner of this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordGuildUser>> GetOwnerAsync();

        /// <summary>
        /// Downloads all users for this guild in the cache if the current list is incomplete and the cache exists.
        /// </summary>
        Task<IMariDiscordRestResult> DownloadUsersAsync();

        /// <summary>
        /// Prunes inactive users.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This method removes all users that have not logged on in the provided number of <paramref name="days"/>.
        ///     </para>
        ///     <para>
        ///         If <paramref name="simulate" /> is <c>true</c>, this method will only return the number of users that
        ///         would be removed without kicking the users.
        ///     </para>
        /// </remarks>
        /// <param name="days">The number of days required for the users to be kicked.</param>
        /// <param name="simulate">Whether this prune action is a simulation.</param>
        /// <returns>
        /// the number of users to be or has been removed from this guild.
        /// </returns>
        Task<IMariDiscordRestResult<int>> PruneUsersAsync(int days = 30, bool simulate = false);

        /// <summary>
        /// The specified number of audit log entries for this guild.
        /// </summary>
        /// <param name="limit">The number of audit log entries to fetch.</param>
        /// <param name="beforeId">The audit log entry ID to get entries before.</param>
        /// <param name="actionType">The type of actions to filter.</param>
        /// <param name="userId">The user ID to filter entries for.</param>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordAuditLogEntry>>> GetAuditLogsAsync(
            int limit = 100,
            ulong? beforeId = null,
            ulong? userId = null,
            MariDiscordActionType? actionType = null);

        /// <summary>
        /// Gets a webhook found within this guild.
        /// </summary>
        /// <param name="id">The identifier for the webhook.</param>
        Task<IMariDiscordRestResult<IMariDiscordWebhook>> GetWebhookAsync(ulong id);

        /// <summary>
        /// Gets a collection of all webhook from this guild.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordWebhook>>> GetWebhooksAsync();

        /// <summary>
        /// Gets a specific emote from this guild.
        /// </summary>
        /// <param name="id">The snowflake identifier for the guild emote.</param>
        Task<IMariDiscordRestResult<IMariDiscordGuildEmote>> GetEmoteAsync(ulong id);

        /// <summary>
        /// Creates a new <see cref="IMariDiscordGuildEmote"/> in this guild.
        /// </summary>
        /// <param name="name">The name of the guild emote.</param>
        /// <param name="image">The image of the new emote.</param>
        /// <param name="roles">The roles to limit the emote usage to.</param>
        Task<IMariDiscordRestResult<IMariDiscordGuildEmote>> CreateEmoteAsync(
            string name,
            IMariDiscordImage image,
            MariDiscordOptional<IEnumerable<IMariDiscordRole>> roles = default);

        /// <summary>
        /// Modifies an existing <see cref="IMariDiscordGuildEmote"/> in this guild.
        /// </summary>
        /// <param name="emote">The emote to be modified.</param>
        /// <param name="func">The delegate containing the properties to modify the emote with.</param>
        Task<IMariDiscordRestResult<IMariDiscordGuildEmote>> ModifyEmoteAsync(IMariDiscordGuildEmote emote, Action<MariDiscordEmoteProperties> func);

        /// <summary>
        /// Deletes an existing <see cref="IMariDiscordGuildEmote"/> from this guild.
        /// </summary>
        /// <param name="emote">The emote to delete.</param>
        Task<IMariDiscordRestResult> DeleteEmoteAsync(IMariDiscordGuildEmote emote);
    }
}