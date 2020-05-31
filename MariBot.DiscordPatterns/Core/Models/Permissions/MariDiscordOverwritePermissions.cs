using MariBot.DiscordPatterns.Core.Utils;

namespace MariBot.DiscordPatterns.Core.Models.Permissions
{
    /// <inheritdoc />
    public class MariDiscordOverwritePermissions : IMariDiscordOverwritePermissions
    {
        /// <inheritdoc />
        public ulong AllowValue { get; }

        /// <inheritdoc />
        public ulong DenyValue { get; }

        /// <summary> 
        /// Creates a new <see cref="MariDiscordOverwritePermissions" /> with the provided allow and deny packed values. 
        /// </summary>
        public MariDiscordOverwritePermissions(ulong allowValue, ulong denyValue)
        {
            AllowValue = allowValue;
            DenyValue = denyValue;
        }

        private MariDiscordOverwritePermissions(ulong allowValue, ulong denyValue,
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
            MariDiscordPermValue? manageWebhooks = null)
        {
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, createInstantInvite, MariDiscordChannelPermission.CreateInstantInvite);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, manageChannel, MariDiscordChannelPermission.ManageChannels);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, addReactions, MariDiscordChannelPermission.AddReactions);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, viewChannel, MariDiscordChannelPermission.ViewChannel);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, sendMessages, MariDiscordChannelPermission.SendMessages);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, sendTTSMessages, MariDiscordChannelPermission.SendTTSMessages);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, manageMessages, MariDiscordChannelPermission.ManageMessages);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, embedLinks, MariDiscordChannelPermission.EmbedLinks);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, attachFiles, MariDiscordChannelPermission.AttachFiles);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, readMessageHistory, MariDiscordChannelPermission.ReadMessageHistory);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, mentionEveryone, MariDiscordChannelPermission.MentionEveryone);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, useExternalEmojis, MariDiscordChannelPermission.UseExternalEmojis);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, connect, MariDiscordChannelPermission.Connect);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, speak, MariDiscordChannelPermission.Speak);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, muteMembers, MariDiscordChannelPermission.MuteMembers);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, deafenMembers, MariDiscordChannelPermission.DeafenMembers);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, moveMembers, MariDiscordChannelPermission.MoveMembers);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, useVoiceActivation, MariDiscordChannelPermission.UseVAD);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, manageRoles, MariDiscordChannelPermission.ManageRoles);
            MariDiscordPermissionsUtils.SetValue(ref allowValue, ref denyValue, manageWebhooks, MariDiscordChannelPermission.ManageWebhooks);

            AllowValue = allowValue;
            DenyValue = denyValue;
        }

        /// <summary>
        /// Initializes a new <see cref="MariDiscordOverwritePermissions"/> struct with the provided permissions.
        /// </summary>
        public MariDiscordOverwritePermissions(
            MariDiscordPermValue createInstantInvite = MariDiscordPermValue.Inherit,
            MariDiscordPermValue manageChannel = MariDiscordPermValue.Inherit,
            MariDiscordPermValue addReactions = MariDiscordPermValue.Inherit,
            MariDiscordPermValue viewChannel = MariDiscordPermValue.Inherit,
            MariDiscordPermValue sendMessages = MariDiscordPermValue.Inherit,
            MariDiscordPermValue sendTTSMessages = MariDiscordPermValue.Inherit,
            MariDiscordPermValue manageMessages = MariDiscordPermValue.Inherit,
            MariDiscordPermValue embedLinks = MariDiscordPermValue.Inherit,
            MariDiscordPermValue attachFiles = MariDiscordPermValue.Inherit,
            MariDiscordPermValue readMessageHistory = MariDiscordPermValue.Inherit,
            MariDiscordPermValue mentionEveryone = MariDiscordPermValue.Inherit,
            MariDiscordPermValue useExternalEmojis = MariDiscordPermValue.Inherit,
            MariDiscordPermValue connect = MariDiscordPermValue.Inherit,
            MariDiscordPermValue speak = MariDiscordPermValue.Inherit,
            MariDiscordPermValue muteMembers = MariDiscordPermValue.Inherit,
            MariDiscordPermValue deafenMembers = MariDiscordPermValue.Inherit,
            MariDiscordPermValue moveMembers = MariDiscordPermValue.Inherit,
            MariDiscordPermValue useVoiceActivation = MariDiscordPermValue.Inherit,
            MariDiscordPermValue manageRoles = MariDiscordPermValue.Inherit,
            MariDiscordPermValue manageWebhooks = MariDiscordPermValue.Inherit)
            : this(0, 0, createInstantInvite, manageChannel, addReactions, viewChannel, sendMessages, sendTTSMessages, manageMessages,
                  embedLinks, attachFiles, readMessageHistory, mentionEveryone, useExternalEmojis, connect, speak, muteMembers, deafenMembers,
                  moveMembers, useVoiceActivation, manageRoles, manageWebhooks)
        { }

        /// <inheritdoc />
        public IMariDiscordOverwritePermissions Modify(
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
            MariDiscordPermValue? manageWebhooks = null)
            => new MariDiscordOverwritePermissions(AllowValue, DenyValue, createInstantInvite, manageChannel, addReactions, viewChannel, sendMessages, sendTTSMessages, manageMessages,
                embedLinks, attachFiles, readMessageHistory, mentionEveryone, useExternalEmojis, connect, speak, muteMembers, deafenMembers,
                moveMembers, useVoiceActivation, manageRoles, manageWebhooks);
    }
}