using MariBot.DiscordPatterns.Core.Models.Permissions;

namespace MariBot.DiscordPatterns.Core.Models.Roles
{
    /// <summary>
    /// Properties that are used to modify an <see cref="IMariDiscordRole" /> with the specified changes.
    /// </summary>
    public class MariDiscordRoleProperties
    {
        /// <summary>
        /// Gets or sets the name of the role.
        /// </summary>
        /// <remarks>
        /// This value may not be set if the role is an @everyone role.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role's <see cref="MariDiscordGuildPermission"/>.
        /// </summary>
        public IMariDiscordGuildPermissions Permissions { get; set; }

        /// <summary>
        /// Gets or sets the position of the role. This is 0-based!
        /// </summary>
        /// <remarks>
        /// This value may not be set if the role is an @everyone role.
        /// </remarks>
        public int? Position { get; set; }


        /// <summary>
        /// Gets or sets the color of the role.
        /// </summary>
        /// <remarks>
        /// This value may not be set if the role is an @everyone role.
        /// </remarks>
        public IMariDiscordColor Color { get; set; }

        /// <summary>
        /// Gets or sets whether or not this role should be displayed independently in the user list.
        /// </summary>
        /// <remarks>
        /// This value may not be set if the role is an @everyone role.
        /// </remarks>
        public bool? Hoist { get; set; }

        /// <summary>
        /// Gets or sets whether or not this role can be mentioned.
        /// </summary>
        /// <remarks>
        /// This value may not be set if the role is an @everyone role.
        /// </remarks>
        public bool? Mentionable { get; set; }
    }
}