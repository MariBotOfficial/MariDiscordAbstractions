using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic guild user.
    /// </summary>
    public interface IMariDiscordGuildUser
    {
        /// <summary>
        /// When this user joined the guild.
        /// </summary>
        DateTimeOffset? JoinedAt { get; }

        /// <summary>
        /// The nickname for this user.
        /// </summary>
        string Nickname { get; }

        /// <summary>
        /// The guild-level permissions for this user.
        /// </summary>
        IMariDiscordGuildPermissions GuildPermissions { get; }

        /// <summary>
        /// The guild for this user.
        /// </summary>
        IMariDiscordGuild Guild { get; }

        /// <summary>
        /// the ID of the guild for this user.
        /// </summary>
        ulong GuildId { get; }

        /// <summary>
        /// The date and time for when this user's guild boost began.
        /// </summary>
        DateTimeOffset? PremiumSince { get; }

        /// <summary>
        /// a collection of IDs for the roles that this user currently possesses in the guild.
        /// </summary>
        /// <remarks>
        /// This property returns a read-only collection of the identifiers of the roles that this user possesses.
        /// For WebSocket users, a Roles property can be found in place of this property. Due to the REST
        /// implementation, only a collection of identifiers can be retrieved instead of the full role objects.
        /// </remarks>
        IReadOnlyCollection<ulong> RoleIds { get; }


        /// <summary>
        /// The level permissions granted to this user to a given channel.
        /// </summary>
        /// <param name="channel">The channel to get the permission from.</param>
        IMariDiscordChannelPermissions GetPermissions(IMariDiscordGuildChannel channel);

        /// <summary>
        ///     Kicks this user from this guild.
        /// </summary>
        /// <param name="reason">The reason for the kick which will be recorded in the audit log.</param>
        Task<IMariDiscordRestResult> KickAsync(string reason = null);

        /// <summary>
        /// Modifies this user's properties in this guild.
        /// </summary>
        /// <param name="func">The delegate containing the properties to modify the user with.</param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordGuildUserProperties> func);

        /// <summary>
        /// Adds the specified role to this user in the guild.
        /// </summary>
        /// <param name="role">The role to be added to the user.</param>
        Task<IMariDiscordRestResult> AddRoleAsync(IMariDiscordRole role);

        /// <summary>
        /// Adds the specified <paramref name="roles"/> to this user in the guild.
        /// </summary>
        /// <param name="roles">The roles to be added to the user.</param>
        Task<IMariDiscordRestResult> AddRolesAsync(IEnumerable<IMariDiscordRole> roles);

        /// <summary>
        /// Removes the specified <paramref name="role"/> from this user in the guild.
        /// </summary>
        /// <param name="role">The role to be removed from the user.</param>
        Task<IMariDiscordRestResult> RemoveRoleAsync(IMariDiscordRole role);

        /// <summary>
        /// Removes the specified <paramref name="roles"/> from this user in the guild.
        /// </summary>
        /// <param name="roles">The roles to be removed from the user.</param>
        Task<IMariDiscordRestResult> RemoveRolesAsync(IEnumerable<IMariDiscordRole> roles);
    }
}