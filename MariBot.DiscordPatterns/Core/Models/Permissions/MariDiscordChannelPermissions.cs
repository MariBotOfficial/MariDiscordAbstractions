namespace MariBot.DiscordPatterns
{
    /// <inheritdoc />
    public class MariDiscordChannelPermissions : IMariDiscordChannelPermissions
    {
        /// <inheritdoc />
        public ulong RawValue { get; }

        /// <summary> 
        /// Creates a new <see cref="MariDiscordChannelPermissions"/> with the provided packed value. 
        /// </summary>
        public MariDiscordChannelPermissions(ulong rawValue) { RawValue = rawValue; }

        private MariDiscordChannelPermissions(ulong initialValue,
            bool? createInstantInvite = null,
            bool? manageChannel = null,
            bool? addReactions = null,
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
            bool? manageRoles = null,
            bool? manageWebhooks = null)
        {
            ulong value = initialValue;

            MariDiscordPermissionsUtils.SetValue(ref value, createInstantInvite, MariDiscordChannelPermission.CreateInstantInvite);
            MariDiscordPermissionsUtils.SetValue(ref value, manageChannel, MariDiscordChannelPermission.ManageChannels);
            MariDiscordPermissionsUtils.SetValue(ref value, addReactions, MariDiscordChannelPermission.AddReactions);
            MariDiscordPermissionsUtils.SetValue(ref value, viewChannel, MariDiscordChannelPermission.ViewChannel);
            MariDiscordPermissionsUtils.SetValue(ref value, sendMessages, MariDiscordChannelPermission.SendMessages);
            MariDiscordPermissionsUtils.SetValue(ref value, sendTTSMessages, MariDiscordChannelPermission.SendTTSMessages);
            MariDiscordPermissionsUtils.SetValue(ref value, manageMessages, MariDiscordChannelPermission.ManageMessages);
            MariDiscordPermissionsUtils.SetValue(ref value, embedLinks, MariDiscordChannelPermission.EmbedLinks);
            MariDiscordPermissionsUtils.SetValue(ref value, attachFiles, MariDiscordChannelPermission.AttachFiles);
            MariDiscordPermissionsUtils.SetValue(ref value, readMessageHistory, MariDiscordChannelPermission.ReadMessageHistory);
            MariDiscordPermissionsUtils.SetValue(ref value, mentionEveryone, MariDiscordChannelPermission.MentionEveryone);
            MariDiscordPermissionsUtils.SetValue(ref value, useExternalEmojis, MariDiscordChannelPermission.UseExternalEmojis);
            MariDiscordPermissionsUtils.SetValue(ref value, connect, MariDiscordChannelPermission.Connect);
            MariDiscordPermissionsUtils.SetValue(ref value, speak, MariDiscordChannelPermission.Speak);
            MariDiscordPermissionsUtils.SetValue(ref value, muteMembers, MariDiscordChannelPermission.MuteMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, deafenMembers, MariDiscordChannelPermission.DeafenMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, moveMembers, MariDiscordChannelPermission.MoveMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, useVoiceActivation, MariDiscordChannelPermission.UseVAD);
            MariDiscordPermissionsUtils.SetValue(ref value, prioritySpeaker, MariDiscordChannelPermission.PrioritySpeaker);
            MariDiscordPermissionsUtils.SetValue(ref value, stream, MariDiscordChannelPermission.Stream);
            MariDiscordPermissionsUtils.SetValue(ref value, manageRoles, MariDiscordChannelPermission.ManageRoles);
            MariDiscordPermissionsUtils.SetValue(ref value, manageWebhooks, MariDiscordChannelPermission.ManageWebhooks);

            RawValue = value;
        }

        /// <summary> 
        /// Creates a new <see cref="MariDiscordChannelPermissions"/> with the provided permissions. 
        /// </summary>
        public MariDiscordChannelPermissions(
            bool createInstantInvite = false,
            bool manageChannel = false,
            bool addReactions = false,
            bool viewChannel = false,
            bool sendMessages = false,
            bool sendTTSMessages = false,
            bool manageMessages = false,
            bool embedLinks = false,
            bool attachFiles = false,
            bool readMessageHistory = false,
            bool mentionEveryone = false,
            bool useExternalEmojis = false,
            bool connect = false,
            bool speak = false,
            bool muteMembers = false,
            bool deafenMembers = false,
            bool moveMembers = false,
            bool useVoiceActivation = false,
            bool prioritySpeaker = false,
            bool stream = false,
            bool manageRoles = false,
            bool manageWebhooks = false)
            : this(0, createInstantInvite, manageChannel, addReactions, viewChannel, sendMessages, sendTTSMessages, manageMessages,
                embedLinks, attachFiles, readMessageHistory, mentionEveryone, useExternalEmojis, connect,
                speak, muteMembers, deafenMembers, moveMembers, useVoiceActivation, prioritySpeaker, stream, manageRoles, manageWebhooks)
        { }

        /// <summary> 
        /// Creates a new <see cref="MariDiscordChannelPermissions"/> from this one, changing the provided non-null permissions. 
        /// </summary>
        public MariDiscordChannelPermissions Modify(
            bool? createInstantInvite = null,
            bool? manageChannel = null,
            bool? addReactions = null,
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
            bool? manageRoles = null,
            bool? manageWebhooks = null)
            => new MariDiscordChannelPermissions(RawValue,
                createInstantInvite,
                manageChannel,
                addReactions,
                viewChannel,
                sendMessages,
                sendTTSMessages,
                manageMessages,
                embedLinks,
                attachFiles,
                readMessageHistory,
                mentionEveryone,
                useExternalEmojis,
                connect,
                speak,
                muteMembers,
                deafenMembers,
                moveMembers,
                useVoiceActivation,
                prioritySpeaker,
                stream,
                manageRoles,
                manageWebhooks);
    }
}