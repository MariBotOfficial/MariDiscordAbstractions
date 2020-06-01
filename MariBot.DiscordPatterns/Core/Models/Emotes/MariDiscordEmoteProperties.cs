using System.Collections.Generic;
using MariBot.DiscordPatterns.Core.Models.Roles;

namespace MariBot.DiscordPatterns.Core.Models.Emotes
{
    /// <summary>
    /// Provides properties that are used to modify an <see cref="IMariDiscordEmote" /> with the specified changes.
    /// </summary>
    public class MariDiscordOptional
    {
        /// <summary>
        /// Gets or sets the name of the <see cref="IMariDiscordEmote"/>.
        /// </summary>
        public MariDiscordOptional<string> Name { get; set; }

        /// <summary>
        /// Gets or sets the roles that can access this <see cref="IMariDiscordEmote"/>.
        /// </summary>
        public MariDiscordOptional<IEnumerable<IMariDiscordRole>> Roles { get; set; }
    }
}