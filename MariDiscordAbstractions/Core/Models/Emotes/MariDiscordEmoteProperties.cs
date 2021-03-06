using System.Collections.Generic;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Provides properties that are used to modify an <see cref="IMariDiscordEmote" /> with the specified changes.
    /// </summary>
    public class MariDiscordEmoteProperties
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