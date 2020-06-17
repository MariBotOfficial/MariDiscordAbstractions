using System.Collections.Generic;

namespace MariBot.DiscordPatterns
{
    /// <inheritdoc />
    public class MariDiscordAllowedMentions : IMariDiscordAllowedMentions
    {
        /// <inheritdoc />
        public MariDiscordAllowedMentionsTypes? AllowedTypes { get; set; }

        /// <inheritdoc />
        public List<ulong> RoleIds { get; set; }

        /// <inheritdoc />
        public List<ulong> UserIds { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MariDiscordAllowedMentions"/> class.
        /// </summary>
        /// <param name="allowedTypes">
        /// The types of mentions to parse from the message content.
        /// If <c>null</c>, only the ids specified in <see cref="UserIds"/> and <see cref="RoleIds"/> will be mentioned.
        /// </param>
        public MariDiscordAllowedMentions(MariDiscordAllowedMentionsTypes? allowedTypes = null)
        {
            AllowedTypes = allowedTypes;
        }
    }
}