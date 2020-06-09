using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic guild channel.
    /// </summary>
    public interface IMariDiscordGuildChannel : IMariDiscordChannel, IMariDiscordDeletable
    {
        /// <summary>
        /// Gets the position of this channel.
        /// </summary>
        int Position { get; }

        /// <summary>
        /// Gets the guild associated with this channel.
        /// </summary>
        IMariDiscordGuild Guild { get; }

        /// <summary>
        /// Gets the guild ID associated with this channel.
        /// </summary>
        ulong GuildId { get; }

        /// <summary>
        /// Gets a collection of permission overwrites for this channel.
        /// </summary>
        IReadOnlyCollection<IMariDiscordOverwrite> PermissionOverwrites { get; }

        /// <summary>
        /// Modifies this guild channel.
        /// </summary>
        /// <param name="func">The delegate containing the properties to modify the channel with.</param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordGuildChannelProperties> func);

        /// <summary>
        /// Gets the permission overwrite for a specific role.
        /// </summary>
        /// <param name="role">The role to get the overwrite from.</param>
        IMariDiscordOverwritePermissions GetPermissionOverwrite(IMariDiscordRole role);

        /// <summary>
        /// Gets the permission overwrite for a specific user.
        /// </summary>
        /// <param name="user">The user to get the overwrite from.</param>
        IMariDiscordOverwritePermissions GetPermissionOverwrite(IMariDiscordUser user);

        /// <summary>
        /// Removes the permission overwrite for the given role, if one exists.
        /// </summary>
        /// <param name="role">The role to remove the overwrite from.</param>
        Task<IMariDiscordRestResult> RemovePermissionOverwriteAsync(IMariDiscordRole role);

        /// <summary>
        /// Removes the permission overwrite for the given user, if one exists.
        /// </summary>
        /// <param name="user">The user to remove the overwrite from.</param>
        Task<IMariDiscordRestResult> RemovePermissionOverwriteAsync(IMariDiscordUser user);

        /// <summary>
        /// Adds or updates the permission overwrite for the given role.
        /// </summary>
        /// <param name="role">The role to add the overwrite to.</param>
        /// <param name="permissions">The overwrite to add to the role.</param>
        Task<IMariDiscordRestResult> AddPermissionOverwriteAsync(IMariDiscordRole role, IMariDiscordOverwritePermissions permissions);

        /// <summary>
        /// Adds or updates the permission overwrite for the given user.
        /// </summary>
        /// <param name="user">The user to add the overwrite to.</param>
        /// <param name="permissions">The overwrite to add to the user.</param>
        Task AddPermissionOverwriteAsync(IMariDiscordUser user, IMariDiscordOverwritePermissions permissions);
    }
}