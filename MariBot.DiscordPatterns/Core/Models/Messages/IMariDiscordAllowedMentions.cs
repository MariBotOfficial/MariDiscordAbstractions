using System;
using System.Collections.Generic;

// Copied from Discord.NET https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Entities/Messages/AllowedMentions.cs
namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Defines which mentions and types of mentions that will notify users from the message content.
    /// </summary>
    public interface IMariDiscordAllowedMentions
    {
        private static readonly Lazy<IMariDiscordAllowedMentions> none
            = new Lazy<IMariDiscordAllowedMentions>(()
                => new MariDiscordAllowedMentions());

        private static readonly Lazy<IMariDiscordAllowedMentions> all
            = new Lazy<IMariDiscordAllowedMentions>(()
                => new MariDiscordAllowedMentions(MariDiscordAllowedMentionsTypes.Everyone |
                                                    MariDiscordAllowedMentionsTypes.Users |
                                                    MariDiscordAllowedMentionsTypes.Roles));

        /// <summary>
        /// A value which indicates that no mentions in the message content should notify users.
        /// </summary>
        static IMariDiscordAllowedMentions None => none.Value;

        /// <summary>
        /// A value which indicates that all mentions in the message content should notify users.
        /// </summary>
        static IMariDiscordAllowedMentions All => all.Value;

        /// <summary>
        ///  The type of mentions that will be parsed from the message content.
        /// </summary>
        /// <remarks>
        /// The <see cref="MariDiscordAllowedMentionsTypes.Users"/> flag is mutually exclusive with the <see cref="UserIds"/>
        /// property, and the <see cref="MariDiscordAllowedMentionsTypes.Roles"/> flag is mutually exclusive with the
        /// <see cref="RoleIds"/> property.
        /// If <c>null</c>, only the ids specified in <see cref="UserIds"/> and <see cref="RoleIds"/> will be mentioned.
        /// </remarks>
        MariDiscordAllowedMentionsTypes? AllowedTypes { get; }

        /// <summary>
        /// Gets or sets the list of all role ids that will be mentioned.
        /// This property is mutually exclusive with the <see cref="MariDiscordAllowedMentionsTypes.Roles"/>
        /// flag of the <see cref="AllowedTypes"/> property. If the flag is set, the value of this property
        /// must be <c>null</c> or empty.
        /// </summary>
        List<ulong> RoleIds { get; }

        /// <summary>
        /// Gets or sets the list of all user ids that will be mentioned.
        /// This property is mutually exclusive with the <see cref="MariDiscordAllowedMentionsTypes.Users"/>
        /// flag of the <see cref="AllowedTypes"/> property. If the flag is set, the value of this property
        /// must be <c>null</c> or empty.
        /// </summary>
        List<ulong> UserIds { get; }
    }
}