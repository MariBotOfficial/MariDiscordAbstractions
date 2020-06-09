using System;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents permissions of a channel.
    /// </summary>
    public interface IMariDiscordChannelPermissions
    {
        /// <summary> 
        /// Gets a blank <see cref="IMariDiscordChannelPermissions"/> that grants no permissions. 
        /// </summary>
        static readonly IMariDiscordChannelPermissions None = new MariDiscordChannelPermissions();

        /// <summary> 
        /// Gets a <see cref="IMariDiscordChannelPermissions"/> that grants all permissions for text channels. 
        /// </summary>
        static readonly IMariDiscordChannelPermissions Text = new MariDiscordChannelPermissions(0b01100_0000000_1111111110001_010001);

        /// <summary> 
        /// Gets a <see cref="IMariDiscordChannelPermissions"/> that grants all permissions for voice channels. 
        /// </summary>
        static readonly IMariDiscordChannelPermissions Voice = new MariDiscordChannelPermissions(0b00100_1111110_0000000011100_010001);

        /// <summary> 
        /// Gets a <see cref="IMariDiscordChannelPermissions"/> that grants all permissions for category channels. 
        /// </summary>
        static readonly IMariDiscordChannelPermissions Category = new MariDiscordChannelPermissions(0b01100_1111110_1111111110001_010001);

        /// <summary> 
        /// Gets a <see cref="IMariDiscordChannelPermissions"/> that grants all permissions for direct message channels. 
        /// </summary>
        static readonly IMariDiscordChannelPermissions DM = new MariDiscordChannelPermissions(0b00000_1000110_1011100110000_000000);

        /// <summary> 
        /// Gets a <see cref="IMariDiscordChannelPermissions"/> that grants all permissions for group channels. 
        /// </summary>
        static readonly IMariDiscordChannelPermissions Group = new MariDiscordChannelPermissions(0b00000_1000110_0001101100000_000000);

        /// <summary> 
        /// Gets a <see cref="IMariDiscordChannelPermissions"/> that grants all permissions for a given channel type. 
        /// </summary>
        /// <exception cref="ArgumentException">Unknown channel type.</exception>
        static IMariDiscordChannelPermissions All(IMariDiscordChannel channel)
        {
            switch (channel)
            {
                case IMariDiscordTextChannel _: return Text;
                case IMariDiscordVoiceChannel _: return Voice;
                case IMariDiscordCategoryChannel _: return Category;
                case IMariDiscordDMChannel _: return DM;
                case IMariDiscordGroupChannel _: return Group;
                default: throw new ArgumentException(message: "Unknown channel type.", paramName: nameof(channel));
            }
        }

        /// <summary> 
        /// Gets a packed value representing all the permissions in this <see cref="IMariDiscordChannelPermissions"/>. 
        /// </summary>
        ulong RawValue { get; }

        /// <summary> 
        /// If <c>true</c>, a user may create invites. 
        /// </summary>
        bool CreateInstantInvite => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.CreateInstantInvite);

        /// <summary> 
        /// If <c>true</c>, a user may create, delete and modify this channel. 
        /// </summary>
        bool ManageChannel => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.ManageChannels);

        /// <summary> 
        /// If <c>true</c>, a user may add reactions. 
        /// </summary>
        bool AddReactions => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.AddReactions);

        /// <summary> 
        /// If <c>true</c>, a user may view channels. 
        /// </summary>
        bool ViewChannel => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.ViewChannel);

        /// <summary> 
        /// If <c>true</c>, a user may send messages. 
        /// </summary>
        bool SendMessages => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.SendMessages);

        /// <summary> 
        /// If <c>true</c>, a user may send text-to-speech messages. 
        /// </summary>
        bool SendTTSMessages => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.SendTTSMessages);

        /// <summary> 
        /// If <c>true</c>, a user may delete messages. 
        /// </summary>
        bool ManageMessages => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.ManageMessages);

        /// <summary> 
        /// If <c>true</c>, Discord will auto-embed links sent by this user. 
        /// </summary>
        bool EmbedLinks => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.EmbedLinks);

        /// <summary> 
        /// If <c>true</c>, a user may send files. 
        /// </summary>
        bool AttachFiles => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.AttachFiles);

        /// <summary> 
        /// If <c>true</c>, a user may read previous messages. 
        /// </summary>
        bool ReadMessageHistory => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.ReadMessageHistory);

        /// <summary> 
        /// If <c>true</c>, a user may mention @everyone. 
        /// </summary>
        bool MentionEveryone => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.MentionEveryone);

        /// <summary> 
        /// If <c>true</c>, a user may use custom emoji from other guilds. 
        /// </summary>
        bool UseExternalEmojis => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.UseExternalEmojis);

        /// <summary> 
        /// If <c>true</c>, a user may connect to a voice channel. 
        /// </summary>
        bool Connect => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.Connect);

        /// <summary> 
        /// If <c>true</c>, a user may speak in a voice channel. 
        /// </summary>
        bool Speak => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.Speak);

        /// <summary> 
        /// If <c>true</c>, a user may mute users. 
        /// </summary>
        bool MuteMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.MuteMembers);

        /// <summary> 
        /// If <c>true</c>, a user may deafen users. 
        /// </summary>
        bool DeafenMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.DeafenMembers);

        /// <summary> 
        /// If <c>true</c>, a user may move other users between voice channels. 
        /// </summary>
        bool MoveMembers => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.MoveMembers);

        /// <summary> 
        /// If <c>true</c>, a user may use voice-activity-detection rather than push-to-talk. 
        /// </summary>
        bool UseVAD => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.UseVAD);

        /// <summary> 
        /// If <c>true</c>, a user may use priority speaker in a voice channel. 
        /// </summary>
        bool PrioritySpeaker => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.PrioritySpeaker);

        /// <summary> 
        /// If <c>true</c>, a user may stream video in a voice channel. 
        /// </summary>
        bool Stream => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.Stream);

        /// <summary> 
        /// If <c>true</c>, a user may adjust role permissions. This also implictly grants all other permissions. 
        /// </summary>
        bool ManageRoles => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.ManageRoles);

        /// <summary> 
        /// If <c>true</c>, a user may edit the webhooks for this channel. 
        /// </summary>
        bool ManageWebhooks => MariDiscordPermissionsUtils.GetValue(RawValue, MariDiscordChannelPermission.ManageWebhooks);
    }
}