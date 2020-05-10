using System;

namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Specifies the type of mentions that will be notified from the message content.
    /// </summary>
    [Flags]
    public enum MariDiscordAllowedMentionsTypes
    {
        /// <summary>
        /// Controls role mentions.
        /// </summary>
        Roles,

        /// <summary>
        /// Controls user mentions.
        /// </summary>
        Users,

        /// <summary>
        /// Controls <code>@everyone</code> and <code>@here</code> mentions.
        /// </summary>
        Everyone,
    }
}