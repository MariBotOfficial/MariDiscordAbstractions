using System.Globalization;
using MariBot.DiscordPatterns.Core.Extensions;
using MariBot.DiscordPatterns.Core.Models.Channels;
using MariBot.DiscordPatterns.Core.Models.Users;

namespace MariBot.DiscordPatterns.Core.Models.Guilds
{
    /// <summary>
    /// Provides properties that are used to modify an <see cref="IMariDiscordGuild" /> with the specified changes.
    /// </summary>
    /// <see cref="IMariDiscordGuild.ModifyAsync"/>
    public class MariDiscordGuildProperties
    {
        /// <summary>
        /// Gets or sets the name of the guild. Must be within 100 characters.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the region for the guild's voice connections.
        /// </summary>
        public IMariDiscordVoiceRegion Region { get; set; }

        /// <summary>
        /// Gets or sets the ID of the region for the guild's voice connections.
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// Gets or sets the verification level new users need to achieve before speaking.
        /// </summary>
        public MariDiscordVerificationLevel? VerificationLevel { get; set; }

        /// <summary>
        /// Gets or sets the default message notification state for the guild.
        /// </summary>
        public MariDiscordDefaultMessageNotifications? DefaultMessageNotifications { get; set; }

        /// <summary>
        /// Gets or sets how many seconds before a user is sent to AFK. This value MUST be one of: (60, 300, 900,
        /// 1800, 3600).
        /// </summary>
        public int AfkTimeout { get; set; }

        /// <summary>
        /// Gets or sets the icon of the guild.
        /// </summary>
        public IMariDiscordImage Icon { get; set; }

        /// <summary>
        /// Gets or sets the banner of the guild.
        /// </summary>
        public IMariDiscordImage Banner { get; set; }

        /// <summary>
        /// Gets or sets the guild's splash image.
        /// </summary>
        /// <remarks>
        /// The guild must be partnered for this value to have any effect.
        /// </remarks>
        public IMariDiscordImage Splash { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="IMariDiscordVoiceChannel"/> where AFK users should be sent.
        /// </summary>
        public IMariDiscordVoiceChannel AfkChannel { get; set; }

        /// <summary>
        /// Gets or sets the ID of the <see cref="IMariDiscordVoiceChannel"/> where AFK users should be sent.
        /// </summary>
        public ulong? AfkChannelId { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="IMariDiscordTextChannel" /> where system messages should be sent.
        /// </summary>
        public IMariDiscordTextChannel SystemChannel { get; set; }

        /// <summary>
        /// Gets or sets the ID of the <see cref="IMariDiscordTextChannel" /> where system messages should be sent.
        /// </summary>
        public ulong? SystemChannelId { get; set; }

        /// <summary>
        /// Gets or sets the owner of this guild.
        /// </summary>
        public IMariDiscordUser Owner { get; set; }

        /// <summary>
        /// Gets or sets the ID of the owner of this guild.
        /// </summary>
        public ulong? OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the explicit content filter level of this guild.
        /// </summary>
        public MariDiscordExplicitContentFilterLevel? ExplicitContentFilter { get; set; }

        /// <summary>
        /// Gets or sets the flags that DISABLE types of system channel messages.
        /// </summary>
        /// <remarks>
        /// These flags are inverted. Setting a flag will disable that system channel message from being sent.
        /// A value of <see cref="MariDiscordSystemChannelMessageDeny.None"/> will allow all system channel message types to be sent,
        /// given that the <see cref="SystemChannelId"/> has also been set.
        /// A value of <see cref="MariDiscordSystemChannelMessageDeny.GuildBoost"/> will deny guild boost messages from being sent, and allow all
        /// other types of messages.
        /// Refer to the extension methods <see cref="MariDiscordGuildExtensions.GetGuildBoostMessagesEnabled(IMariDiscordGuild)"/> and
        /// <see cref="MariDiscordGuildExtensions.GetWelcomeMessagesEnabled(IMariDiscordGuild)"/> to check if these system channel message types
        /// are enabled, without the need to manipulate the logic of the flag.
        /// </remarks>
        public MariDiscordSystemChannelMessageDeny? SystemChannelFlags { get; set; }

        /// <summary>
        /// Gets or sets the preferred locale of the guild in IETF BCP 47 language tag format.
        /// </summary>
        /// <remarks>
        /// This property takes precedence over <see cref="PreferredCulture"/>.
        /// When it is set, the value of <see cref="PreferredCulture"/>
        /// will not be used.
        /// </remarks>
        public string PreferredLocale { get; set; }

        /// <summary>
        /// Gets or sets the preferred locale of the guild.
        /// </summary>
        /// <remarks>
        /// The <see cref="PreferredLocale"/> property takes precedence
        /// over this property. When <see cref="PreferredLocale"/> is set,
        /// the value of <see cref="PreferredCulture"/> will be unused.
        /// </remarks>
        public CultureInfo PreferredCulture { get; set; }

    }
}