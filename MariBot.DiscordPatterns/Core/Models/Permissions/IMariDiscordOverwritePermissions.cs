using System;
using System.Collections.Generic;
using MariBot.DiscordPatterns.Core.Models.Channels;
using MariBot.DiscordPatterns.Core.Utils;

namespace MariBot.DiscordPatterns.Core.Models.Permissions
{
    /// <summary>
    /// Represents a container for a series of overwrite permissions.
    /// </summary>
    public interface IMariDiscordOverwritePermissions
    {
        /// <summary>
        ///     Gets a blank <see cref="IMariDiscordOverwritePermissions" /> that inherits all permissions.
        /// </summary>
        static IMariDiscordOverwritePermissions InheritAll { get; } = new MariDiscordOverwritePermissions();

        /// <summary>
        ///     Gets a <see cref="IMariDiscordOverwritePermissions" /> that grants all permissions for the given channel.
        /// </summary>
        /// <exception cref="ArgumentException">Unknown channel type.</exception>
        static IMariDiscordOverwritePermissions AllowAll(IMariDiscordChannel channel)
           => new MariDiscordOverwritePermissions(IMariDiscordChannelPermissions.All(channel).RawValue, 0);

        /// <summary>
        ///     Gets a <see cref="IMariDiscordOverwritePermissions" /> that denies all permissions for the given channel.
        /// </summary>
        /// <exception cref="ArgumentException">Unknown channel type.</exception>
        static IMariDiscordOverwritePermissions DenyAll(IMariDiscordChannel channel)
           => new MariDiscordOverwritePermissions(0, IMariDiscordChannelPermissions.All(channel).RawValue);

        /// <summary>
        /// Gets a packed value representing all the allowed permissions in this <see cref="IMariDiscordOverwritePermissions"/>.
        /// </summary>
        ulong AllowValue { get; }

        /// <summary>
        /// Gets a packed value representing all the denied permissions in this <see cref="IMariDiscordOverwritePermissions"/>.
        /// </summary>
        ulong DenyValue { get; }

        /// <summary> 
        /// If Allowed, a user may create invites. 
        /// </summary>
        MariDiscordPermValue CreateInstantInvite => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.CreateInstantInvite);

        /// <summary> 
        /// If Allowed, a user may create, delete and modify this channel. 
        /// </summary>
        MariDiscordPermValue ManageChannel => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.ManageChannels);

        /// <summary> 
        /// If Allowed, a user may add reactions. 
        /// </summary>
        MariDiscordPermValue AddReactions => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.AddReactions);

        /// <summary> 
        /// If Allowed, a user may join channels. 
        /// </summary>
        MariDiscordPermValue ViewChannel => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.ViewChannel);

        /// <summary> 
        /// If Allowed, a user may send messages. 
        /// </summary>
        MariDiscordPermValue SendMessages => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.SendMessages);

        /// <summary> 
        /// If Allowed, a user may send text-to-speech messages. 
        /// </summary>
        MariDiscordPermValue SendTTSMessages => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.SendTTSMessages);

        /// <summary> 
        /// If Allowed, a user may delete messages. 
        /// </summary>
        MariDiscordPermValue ManageMessages => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.ManageMessages);

        /// <summary> 
        /// If Allowed, Discord will auto-embed links sent by this user. 
        /// </summary>
        MariDiscordPermValue EmbedLinks => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.EmbedLinks);

        /// <summary> 
        /// If Allowed, a user may send files. 
        /// </summary>
        MariDiscordPermValue AttachFiles => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.AttachFiles);

        /// <summary> 
        /// If Allowed, a user may read previous messages. 
        /// </summary>
        MariDiscordPermValue ReadMessageHistory => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.ReadMessageHistory);

        /// <summary> 
        /// If Allowed, a user may mention @everyone. 
        /// </summary>
        MariDiscordPermValue MentionEveryone => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.MentionEveryone);

        /// <summary> 
        /// If Allowed, a user may use custom emoji from other guilds. 
        /// </summary>
        MariDiscordPermValue UseExternalEmojis => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.UseExternalEmojis);

        /// <summary> 
        /// If Allowed, a user may connect to a voice channel. 
        /// </summary>
        MariDiscordPermValue Connect => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.Connect);

        /// <summary> 
        /// If Allowed, a user may speak in a voice channel. 
        /// </summary>
        MariDiscordPermValue Speak => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.Speak);

        /// <summary> 
        /// If Allowed, a user may mute users. 
        /// </summary>
        MariDiscordPermValue MuteMembers => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.MuteMembers);

        /// <summary> 
        /// If Allowed, a user may deafen users. 
        /// </summary>
        MariDiscordPermValue DeafenMembers => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.DeafenMembers);

        /// <summary> 
        /// If Allowed, a user may move other users between voice channels. 
        /// </summary>
        MariDiscordPermValue MoveMembers => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.MoveMembers);

        /// <summary> 
        /// If Allowed, a user may use voice-activity-detection rather than push-to-talk. 
        /// </summary>
        MariDiscordPermValue UseVAD => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.UseVAD);

        /// <summary> 
        /// If Allowed, a user may adjust role permissions. This also implicitly grants all other permissions. 
        /// </summary>
        MariDiscordPermValue ManageRoles => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.ManageRoles);

        /// <summary> 
        /// If True, a user may edit the webhooks for this channel. 
        /// </summary>
        MariDiscordPermValue ManageWebhooks => MariDiscordPermissionsUtils.GetValue(AllowValue, DenyValue, MariDiscordChannelPermission.ManageWebhooks);

        /// <summary>
        /// Creates a <see cref="List{T}"/> of all the <see cref="MariDiscordChannelPermission"/> values that are allowed.
        /// </summary>
        List<MariDiscordChannelPermission> ToAllowList()
        {
            var perms = new List<MariDiscordChannelPermission>();
            for (byte i = 0; i < MariDiscordPermissionsUtils.MaxBits; i++)
            {
                // first operand must be long or ulong to shift >31 bits
                var flag = ((ulong)1 << i);
                if ((AllowValue & flag) != 0)
                    perms.Add((MariDiscordChannelPermission)flag);
            }
            return perms;
        }

        /// <summary>
        /// Creates a <see cref="List{T}"/> of all the <see cref="MariDiscordChannelPermission"/> values that are denied.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of all denied <see cref="MariDiscordChannelPermission"/> flags. If none, the list will be empty.</returns>
        List<MariDiscordChannelPermission> ToDenyList()
        {
            var perms = new List<MariDiscordChannelPermission>();
            for (byte i = 0; i < MariDiscordPermissionsUtils.MaxBits; i++)
            {
                var flag = ((ulong)1 << i);
                if ((DenyValue & flag) != 0)
                    perms.Add((MariDiscordChannelPermission)flag);
            }
            return perms;
        }

        /// <summary>
        /// Initializes a new <see cref="IMariDiscordOverwritePermissions" /> from the current one, changing the provided
        /// non-null permissions.
        /// </summary>
        IMariDiscordOverwritePermissions Modify(
            MariDiscordPermValue? createInstantInvite = null,
            MariDiscordPermValue? manageChannel = null,
            MariDiscordPermValue? addReactions = null,
            MariDiscordPermValue? viewChannel = null,
            MariDiscordPermValue? sendMessages = null,
            MariDiscordPermValue? sendTTSMessages = null,
            MariDiscordPermValue? manageMessages = null,
            MariDiscordPermValue? embedLinks = null,
            MariDiscordPermValue? attachFiles = null,
            MariDiscordPermValue? readMessageHistory = null,
            MariDiscordPermValue? mentionEveryone = null,
            MariDiscordPermValue? useExternalEmojis = null,
            MariDiscordPermValue? connect = null,
            MariDiscordPermValue? speak = null,
            MariDiscordPermValue? muteMembers = null,
            MariDiscordPermValue? deafenMembers = null,
            MariDiscordPermValue? moveMembers = null,
            MariDiscordPermValue? useVoiceActivation = null,
            MariDiscordPermValue? manageRoles = null,
            MariDiscordPermValue? manageWebhooks = null);
    }
}