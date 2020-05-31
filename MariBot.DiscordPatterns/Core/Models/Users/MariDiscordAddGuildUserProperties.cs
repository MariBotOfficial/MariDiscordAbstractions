using System.Collections.Generic;
using MariBot.DiscordPatterns.Core.Models.Roles;

namespace MariBot.DiscordPatterns.Core.Models.Users
{
    /// <summary>
    /// Properties that are used to add a new <see cref="IMariDiscordGuildUser"/> to the guild with the following parameters.
    /// </summary>
    public class MariDiscordAddGuildUserProperties
    {
        /// <summary>
        /// Gets or sets the user's nickname.
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets whether the user should be muted in a voice channel.
        /// </summary>
        public bool? Mute { get; set; }

        /// <summary>
        /// Gets or sets whether the user should be deafened in a voice channel.
        /// </summary>
        public bool? Deaf { get; set; }

        /// <summary>
        /// Gets or sets the roles the user should have.
        /// </summary>
        public IEnumerable<IMariDiscordRole> Roles { get; set; }

        /// <summary>
        /// Gets or sets the roles the user should have.
        /// </summary>
        public IEnumerable<ulong> RoleIds { get; set; }
    }
}