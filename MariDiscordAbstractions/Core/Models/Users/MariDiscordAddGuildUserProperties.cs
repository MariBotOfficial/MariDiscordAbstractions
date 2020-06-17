using System.Collections.Generic;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Properties that are used to add a new <see cref="IMariDiscordGuildUser"/> to the guild with the following parameters.
    /// </summary>
    public class MariDiscordAddGuildUserProperties
    {
        /// <summary>
        /// Gets or sets the user's nickname.
        /// </summary>
        public MariDiscordOptional<string> Nickname { get; set; }

        /// <summary>
        /// Gets or sets whether the user should be muted in a voice channel.
        /// </summary>
        public MariDiscordOptional<bool> Mute { get; set; }

        /// <summary>
        /// Gets or sets whether the user should be deafened in a voice channel.
        /// </summary>
        public MariDiscordOptional<bool> Deaf { get; set; }

        /// <summary>
        /// Gets or sets the roles the user should have.
        /// </summary>
        public MariDiscordOptional<IEnumerable<IMariDiscordRole>> Roles { get; set; }

        /// <summary>
        /// Gets or sets the roles the user should have.
        /// </summary>
        public MariDiscordOptional<IEnumerable<ulong>> RoleIds { get; set; }
    }
}