using System.Collections.Generic;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents permissions of any entity of a guild.
    /// </summary>
    public interface IMariDiscordGuildPermissions
    {
        /// <summary> 
        /// Gets a blank <see cref="IMariDiscordGuildPermissions"/> that grants no permissions. 
        /// </summary>
        static readonly IMariDiscordGuildPermissions None = new MariDiscordGuildPermissions();

        /// <summary>
        /// Gets a <see cref="IMariDiscordGuildPermissions"/> that grants all guild permissions for webhook users.
        /// </summary>
        static readonly IMariDiscordGuildPermissions Webhook = new MariDiscordGuildPermissions(0b00000_0000000_0001101100000_000000);

        /// <summary>
        /// Gets a <see cref="IMariDiscordGuildPermissions"/> that grants all guild permissions.
        /// </summary>
        static readonly IMariDiscordGuildPermissions All = new MariDiscordGuildPermissions(0b11111_1111110_1111111111111_111111);

        /// <summary>
        /// Gets a packed value representing all the permissions in this <see cref="IMariDiscordGuildPermissions"/>.
        /// </summary>
        ulong RawValue { get; }

        /// <summary>
        /// If <c>true</c>, a user may create invites.
        /// </summary>
        bool CreateInstantInvite => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.CreateInstantInvite);

        /// <summary>
        /// If <c>true</c>, a user may ban users from the guild.
        /// </summary>
        bool BanMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.BanMembers);

        /// <summary>
        /// If <c>true</c>, a user may kick users from the guild.
        /// </summary>
        bool KickMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.KickMembers);

        /// <summary>
        /// If <c>true</c>, a user is granted all permissions, and cannot have them revoked via channel permissions.
        /// </summary>
        bool Administrator => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.Administrator);

        /// <summary>
        /// If <c>true</c>, a user may create, delete and modify channels.
        /// </summary>
        bool ManageChannels => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ManageChannels);

        /// <summary>
        /// If <c>true</c>, a user may adjust guild properties.
        /// </summary>
        bool ManageGuild => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ManageGuild);

        /// <summary>
        /// If <c>true</c>, a user may add reactions.
        /// </summary>
        bool AddReactions => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.AddReactions);

        /// <summary>
        /// If <c>true</c>, a user may view the audit log.
        /// </summary>
        bool ViewAuditLog => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ViewAuditLog);

        /// <summary>
        /// If True, a user may view channels.
        /// </summary>
        bool ViewChannel => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ViewChannel);

        /// <summary>
        /// If True, a user may send messages.
        /// </summary>
        bool SendMessages => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.SendMessages);

        /// <summary>
        /// If <c>true</c>, a user may send text-to-speech messages.
        /// </summary>
        bool SendTTSMessages => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.SendTTSMessages);

        /// <summary>
        /// If <c>true</c>, a user may delete messages.
        /// </summary>
        bool ManageMessages => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ManageMessages);

        /// <summary>
        /// If <c>true</c>, Discord will auto-embed links sent by this user.
        /// </summary>
        bool EmbedLinks => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.EmbedLinks);

        /// <summary>
        /// If <c>true</c>, a user may send files.
        /// </summary>
        bool AttachFiles => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.AttachFiles);

        /// <summary>
        /// If <c>true</c>, a user may read previous messages.
        /// </summary>
        bool ReadMessageHistory => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ReadMessageHistory);

        /// <summary>
        /// If <c>true</c>, a user may mention @everyone.
        /// </summary>
        bool MentionEveryone => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.MentionEveryone);

        /// <summary>
        /// If <c>true</c>, a user may use custom emoji from other guilds.
        /// </summary>
        bool UseExternalEmojis => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.UseExternalEmojis);

        ///<summary>
        ///If <c>true</c>, a user may connect to a voice channel.
        ///</summary>
        bool Connect => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.Connect);
        ///<summary>
        ///If <c>true</c>, a user may speak in a voice channel.
        ///</summary>
        bool Speak => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.Speak);
        ///<summary>
        ///If <c>true</c>, a user may mute users.
        ///</summary>
        bool MuteMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.MuteMembers);
        ///<summary>
        ///If <c>true</c>, a user may deafen users.
        ///</summary>
        bool DeafenMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.DeafenMembers);
        ///<summary>
        ///If <c>true</c>, a user may move other users between voice channels.
        ///</summary>
        bool MoveMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.MoveMembers);
        ///<summary>
        ///If <c>true</c>, a user may use voice-activity-detection rather than push-to-talk.
        ///</summary>
        bool UseVAD => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.UseVAD);
        ///<summary>
        ///If True, a user may use priority speaker in a voice channel.
        ///</summary>
        bool PrioritySpeaker => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.PrioritySpeaker);
        ///<summary>
        ///If True, a user may stream video in a voice channel.
        ///</summary>
        bool Stream => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.Stream);

        ///<summary>
        ///If <c>true</c>, a user may change their own nickname.
        ///</summary>
        bool ChangeNickname => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ChangeNickname);
        ///<summary>
        ///If <c>true</c>, a user may change the nickname of other users.
        ///</summary>
        bool ManageNicknames => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ManageNicknames);
        ///<summary>
        ///If <c>true</c>, a user may adjust roles.
        ///</summary>
        bool ManageRoles => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ManageRoles);
        ///<summary>
        ///If <c>true</c>, a user may edit the webhooks for this guild.
        ///</summary>
        bool ManageWebhooks => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ManageWebhooks);
        ///<summary>
        ///If <c>true</c>, a user may edit the emojis for this guild.
        ///</summary>
        bool ManageEmojis => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordGuildPermission.ManageEmojis);

        /// <summary>
        /// Returns a value that indicates if a specific <see cref="MariDiscordGuildPermission"/> is enabled
        /// in these permissions.
        /// </summary>
        /// <param name="permission">The permission value to check for.</param>
        /// <returns><c>true</c> if the permission is enabled, <c>false</c> otherwise.</returns>
        bool Has(MariDiscordGuildPermission permission)
            => MariDiscordPermissionsUtils.GetValue(RawValue, permission);

        /// <summary>
        /// Returns a <see cref="List{T}"/> containing all of the <see cref="MariDiscordGuildPermission"/>
        /// flags that are enabled.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> containing <see cref="MariDiscordGuildPermission"/> flags. 
        /// Empty if none are enabled.</returns>
        List<MariDiscordGuildPermission> ToList()
        {
            var perms = new List<MariDiscordGuildPermission>();

            // bitwise operations on raw value
            // each of the GuildPermissions increments by 2^i from 0 to MaxBits
            for (byte i = 0; i < MariDiscordPermissionsUtils.MaxBits; i++)
            {
                var flag = ((ulong)1 << i);
                if ((RawValue & flag) != 0)
                    perms.Add((MariDiscordGuildPermission)flag);
            }

            return perms;
        }


        /// <summary> 
        /// Creates a new <see cref="MariDiscordGuildPermissions"/> from this one, changing the provided non-null permissions. 
        /// </summary>
        IMariDiscordGuildPermissions Modify(
            bool? createInstantInvite = null,
            bool? kickMembers = null,
            bool? banMembers = null,
            bool? administrator = null,
            bool? manageChannels = null,
            bool? manageGuild = null,
            bool? addReactions = null,
            bool? viewAuditLog = null,
            bool? viewChannel = null,
            bool? sendMessages = null,
            bool? sendTTSMessages = null,
            bool? manageMessages = null,
            bool? embedLinks = null,
            bool? attachFiles = null,
            bool? readMessageHistory = null,
            bool? mentionEveryone = null,
            bool? useExternalEmojis = null,
            bool? connect = null,
            bool? speak = null,
            bool? muteMembers = null,
            bool? deafenMembers = null,
            bool? moveMembers = null,
            bool? useVoiceActivation = null,
            bool? prioritySpeaker = null,
            bool? stream = null,
            bool? changeNickname = null,
            bool? manageNicknames = null,
            bool? manageRoles = null,
            bool? manageWebhooks = null,
            bool? manageEmojis = null);
    }
}