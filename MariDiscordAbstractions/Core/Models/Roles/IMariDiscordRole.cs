using System;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic role object to be given to a guild user.
    /// </summary>
    public interface IMariDiscordRole : IMariDiscordSnowFlakeEntity, IMariDiscordDeletable, IMariDiscordMentionable
    {
        /// <summary>
        /// The guild that owns this role.
        /// </summary>
        IMariDiscordGuild Guild { get; }

        /// <summary>
        /// The color given to users of this role.
        /// </summary>
        IMariDiscordColor Color { get; }

        /// <summary>
        /// Indicates whether the role can be separated in the user list.
        /// </summary>
        bool IsHoisted { get; }

        /// <summary>
        /// Indicates whether the role is managed by Discord.
        /// </summary>
        bool IsManaged { get; }

        /// <summary>
        /// Indicates whether the role is mentionable.
        /// </summary>
        bool IsMentionable { get; }

        /// <summary>
        /// The name of this role.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The permissions granted to members of this role.
        /// </summary>
        IMariDiscordGuildPermissions Permissions { get; }

        /// <summary>
        /// This role's position relative to other roles in the same guild.
        /// </summary>
        int Position { get; }

        /// <summary>
        /// Modifies this role.
        /// </summary>
        /// <param name="func">A delegate containing the properties to modify the role with.</param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordRoleProperties> func);
    }
}