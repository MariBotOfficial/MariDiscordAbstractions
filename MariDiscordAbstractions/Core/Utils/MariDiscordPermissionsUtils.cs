using System.Runtime.CompilerServices;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Provides a series of helper methods for handling permissions.
    /// </summary>
    public static class MariDiscordPermissionsUtils
    {
        /// <summary>
        /// Max bits of a flag.
        /// </summary>
        public const int MaxBits = 53;

        /// <summary>
        /// Return a <see cref="MariDiscordPermValue" /> of this flag.
        /// </summary>
        /// <param name="allow">A packed value representing all the allowed permissions.</param>
        /// <param name="deny">A packed value representing all the denied permissions.</param>
        /// <param name="flag">Permission flag of a channel.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MariDiscordPermValue GetValue(ulong allow, ulong deny, MariDiscordChannelPermission flag)
            => GetValue(allow, deny, (ulong)flag);

        /// <summary>
        /// Return a <see cref="MariDiscordPermValue" /> of this flag.
        /// </summary>
        /// <param name="allow">A packed value representing all the allowed permissions.</param>
        /// <param name="deny">A packed value representing all the denied permissions.</param>
        /// <param name="flag">Permission flag of a guild entity.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MariDiscordPermValue GetValue(ulong allow, ulong deny, MariDiscordGuildPermission flag)
            => GetValue(allow, deny, (ulong)flag);

        /// <summary>
        /// Return a <see cref="MariDiscordPermValue" /> of this flag.
        /// </summary>
        /// <param name="allow">A packed value representing all the allowed permissions.</param>
        /// <param name="deny">A packed value representing all the denied permissions.</param>
        /// <param name="flag">Permission flag.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MariDiscordPermValue GetValue(ulong allow, ulong deny, ulong flag)
        {
            if (HasFlag(allow, flag))
                return MariDiscordPermValue.Allow;
            else if (HasFlag(deny, flag))
                return MariDiscordPermValue.Deny;
            else
                return MariDiscordPermValue.Inherit;
        }

        /// <summary>
        /// Return if this flag is allowed.
        /// </summary>
        /// <param name="value">The raw value of permissions in this channel.</param>
        /// <param name="flag">Permission flag of a channel.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetValue(ulong value, MariDiscordChannelPermission flag)
            => GetValue(value, (ulong)flag);

        /// <summary>
        /// Return if this flag is allowed.
        /// </summary>
        /// <param name="value">The raw value of permissions in this guild entity.</param>
        /// <param name="flag">Permission flag of a guild entity.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetValue(ulong value, MariDiscordGuildPermission flag)
            => GetValue(value, (ulong)flag);

        /// <summary>
        /// Return if this flag is allowed.
        /// </summary>
        /// <param name="value">The raw value of permissions.</param>
        /// <param name="flag">Permission flag.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetValue(ulong value, ulong flag) => HasFlag(value, flag);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool HasFlag(ulong value, ulong flag) => (value & flag) == flag;

        /// <summary>
        /// Set a value for a flag
        /// </summary>
        /// <param name="rawValue">The raw value of permissions.</param>
        /// <param name="value">The new value for this flag.</param>
        /// <param name="flag">The flag to be changed.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetValue(ref ulong rawValue, bool? value, MariDiscordChannelPermission flag)
            => SetValue(ref rawValue, value, (ulong)flag);

        /// <summary>
        /// Set a value for a flag
        /// </summary>
        /// <param name="rawValue">The raw value of permissions.</param>
        /// <param name="value">The new value for this flag.</param>
        /// <param name="flag">The flag to be changed.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetValue(ref ulong rawValue, bool? value, MariDiscordGuildPermission flag)
            => SetValue(ref rawValue, value, (ulong)flag);

        /// <summary>
        /// Set a value for a flag
        /// </summary>
        /// <param name="rawValue">The raw value of permissions.</param>
        /// <param name="value">The new value for this flag.</param>
        /// <param name="flag">The flag to be changed.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetValue(ref ulong rawValue, bool? value, ulong flag)
        {
            if (value.HasValue)
            {
                if (value == true)
                    SetFlag(ref rawValue, flag);
                else
                    UnsetFlag(ref rawValue, flag);
            }
        }

        /// <summary>
        /// Set a value for a flag
        /// </summary>
        /// <param name="allow">A packed value representing all the allowed permissions.</param>
        /// <param name="deny">A packed value representing all the denied permissions.</param>
        /// <param name="value">The new value for this flag.</param>
        /// <param name="flag">The flag to be changed.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetValue(ref ulong allow, ref ulong deny, MariDiscordPermValue? value, MariDiscordChannelPermission flag)
            => SetValue(ref allow, ref deny, value, (ulong)flag);

        /// <summary>
        /// Set a value for a flag
        /// </summary>
        /// <param name="allow">A packed value representing all the allowed permissions.</param>
        /// <param name="deny">A packed value representing all the denied permissions.</param>
        /// <param name="value">The new value for this flag.</param>
        /// <param name="flag">The flag to be changed.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetValue(ref ulong allow, ref ulong deny, MariDiscordPermValue? value, MariDiscordGuildPermission flag)
            => SetValue(ref allow, ref deny, value, (ulong)flag);

        /// <summary>
        /// Set a value for a flag
        /// </summary>
        /// <param name="allow">A packed value representing all the allowed permissions.</param>
        /// <param name="deny">A packed value representing all the denied permissions.</param>
        /// <param name="value">The new value for this flag.</param>
        /// <param name="flag">The flag to be changed.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetValue(ref ulong allow, ref ulong deny, MariDiscordPermValue? value, ulong flag)
        {
            if (value.HasValue)
            {
                switch (value)
                {
                    case MariDiscordPermValue.Allow:
                        SetFlag(ref allow, flag);
                        UnsetFlag(ref deny, flag);
                        break;
                    case MariDiscordPermValue.Deny:
                        UnsetFlag(ref allow, flag);
                        SetFlag(ref deny, flag);
                        break;
                    default:
                        UnsetFlag(ref allow, flag);
                        UnsetFlag(ref deny, flag);
                        break;
                }
            }
        }

        /// <summary>
        /// Set a value for a flag.
        /// </summary>
        /// <param name="value">The value for this flag.</param>
        /// <param name="flag">The flag.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFlag(ref ulong value, ulong flag) => value |= flag;

        /// <summary>
        /// Unset a value for a flag.
        /// </summary>
        /// <param name="value">The valeu for this flag.</param>
        /// <param name="flag">The flag.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnsetFlag(ref ulong value, ulong flag) => value &= ~flag;

        // public static IMariDiscordChannelPermissions ToChannelPerms(IGuildChannel channel, ulong MariDiscordGuildPermissions)
        //     => new IMariDiscordChannelPermissions(MariDiscordGuildPermissions & IMariDiscordChannelPermissions.All(channel).RawValue);

        // public static ulong ResolveGuild(IGuild guild, IGuildUser user)
        // {
        //     ulong resolvedPermissions = 0;

        //     if (user.Id == guild.OwnerId)
        //         resolvedPermissions = MariDiscordGuildPermissions.All.RawValue; //Owners always have all permissions
        //     else if (user.IsWebhook)
        //         resolvedPermissions = MariDiscordGuildPermissions.Webhook.RawValue;
        //     else
        //     {
        //         foreach (var roleId in user.RoleIds)
        //             resolvedPermissions |= guild.GetRole(roleId)?.Permissions.RawValue ?? 0;
        //         if (GetValue(resolvedPermissions, MariDiscordGuildPermission.Administrator))
        //             resolvedPermissions = MariDiscordGuildPermissions.All.RawValue; //Administrators always have all permissions
        //     }
        //     return resolvedPermissions;
        // }

        // public static ulong ResolveChannel(IGuild guild, IGuildUser user, IGuildChannel channel, ulong MariDiscordGuildPermissions)
        // {
        //     ulong resolvedPermissions = 0;

        //     ulong mask = IMariDiscordChannelPermissions.All(channel).RawValue;
        //     if (GetValue(MariDiscordGuildPermissions, MariDiscordGuildPermission.Administrator)) //Includes owner
        //         resolvedPermissions = mask; //Owners and administrators always have all permissions
        //     else
        //     {
        //         //Start with this user's guild permissions
        //         resolvedPermissions = MariDiscordGuildPermissions;

        //         //Give/Take Everyone permissions
        //         var perms = channel.GetPermissionOverwrite(guild.EveryoneRole);
        //         if (perms != null)
        //             resolvedPermissions = (resolvedPermissions & ~perms.Value.DenyValue) | perms.Value.AllowValue;

        //         //Give/Take Role permissions
        //         ulong deniedPermissions = 0UL, allowedPermissions = 0UL;
        //         foreach (var roleId in user.RoleIds)
        //         {
        //             IRole role;
        //             if (roleId != guild.EveryoneRole.Id && (role = guild.GetRole(roleId)) != null)
        //             {
        //                 perms = channel.GetPermissionOverwrite(role);
        //                 if (perms != null)
        //                 {
        //                     allowedPermissions |= perms.Value.AllowValue;
        //                     deniedPermissions |= perms.Value.DenyValue;
        //                 }
        //             }
        //         }
        //         resolvedPermissions = (resolvedPermissions & ~deniedPermissions) | allowedPermissions;

        //         //Give/Take User permissions
        //         perms = channel.GetPermissionOverwrite(user);
        //         if (perms != null)
        //             resolvedPermissions = (resolvedPermissions & ~perms.Value.DenyValue) | perms.Value.AllowValue;

        //         if (channel is ITextChannel)
        //         {
        //             if (!GetValue(resolvedPermissions, ChannelPermission.ViewChannel))
        //             {
        //                 //No read permission on a text channel removes all other permissions
        //                 resolvedPermissions = 0;
        //             }
        //             else if (!GetValue(resolvedPermissions, ChannelPermission.SendMessages))
        //             {
        //                 //No send permissions on a text channel removes all send-related permissions
        //                 resolvedPermissions &= ~(ulong)ChannelPermission.SendTTSMessages;
        //                 resolvedPermissions &= ~(ulong)ChannelPermission.MentionEveryone;
        //                 resolvedPermissions &= ~(ulong)ChannelPermission.EmbedLinks;
        //                 resolvedPermissions &= ~(ulong)ChannelPermission.AttachFiles;
        //             }
        //         }
        //         resolvedPermissions &= mask; //Ensure we didn't get any permissions this channel doesn't support (from guildPerms, for example)
        //     }

        //     return resolvedPermissions;
        // }
    }
}