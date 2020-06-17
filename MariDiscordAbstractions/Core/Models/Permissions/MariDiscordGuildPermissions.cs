namespace MariBot.DiscordPatterns
{
    /// <inheritdoc />
    public class MariDiscordGuildPermissions : IMariDiscordGuildPermissions
    {
        /// <inheritdoc />
        public ulong RawValue { get; }

        /// <summary> 
        /// Creates a new <see cref="MariDiscordGuildPermissions"/> with the provided packed value. 
        /// </summary>
        public MariDiscordGuildPermissions(ulong rawValue)
        {
            RawValue = rawValue;
        }

        private MariDiscordGuildPermissions(ulong initialValue,
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
            bool? manageEmojis = null)
        {
            ulong value = initialValue;

            MariDiscordPermissionsUtils.SetValue(ref value, createInstantInvite, MariDiscordGuildPermission.CreateInstantInvite);
            MariDiscordPermissionsUtils.SetValue(ref value, banMembers, MariDiscordGuildPermission.BanMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, kickMembers, MariDiscordGuildPermission.KickMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, administrator, MariDiscordGuildPermission.Administrator);
            MariDiscordPermissionsUtils.SetValue(ref value, manageChannels, MariDiscordGuildPermission.ManageChannels);
            MariDiscordPermissionsUtils.SetValue(ref value, manageGuild, MariDiscordGuildPermission.ManageGuild);
            MariDiscordPermissionsUtils.SetValue(ref value, addReactions, MariDiscordGuildPermission.AddReactions);
            MariDiscordPermissionsUtils.SetValue(ref value, viewAuditLog, MariDiscordGuildPermission.ViewAuditLog);
            MariDiscordPermissionsUtils.SetValue(ref value, viewChannel, MariDiscordGuildPermission.ViewChannel);
            MariDiscordPermissionsUtils.SetValue(ref value, sendMessages, MariDiscordGuildPermission.SendMessages);
            MariDiscordPermissionsUtils.SetValue(ref value, sendTTSMessages, MariDiscordGuildPermission.SendTTSMessages);
            MariDiscordPermissionsUtils.SetValue(ref value, manageMessages, MariDiscordGuildPermission.ManageMessages);
            MariDiscordPermissionsUtils.SetValue(ref value, embedLinks, MariDiscordGuildPermission.EmbedLinks);
            MariDiscordPermissionsUtils.SetValue(ref value, attachFiles, MariDiscordGuildPermission.AttachFiles);
            MariDiscordPermissionsUtils.SetValue(ref value, readMessageHistory, MariDiscordGuildPermission.ReadMessageHistory);
            MariDiscordPermissionsUtils.SetValue(ref value, mentionEveryone, MariDiscordGuildPermission.MentionEveryone);
            MariDiscordPermissionsUtils.SetValue(ref value, useExternalEmojis, MariDiscordGuildPermission.UseExternalEmojis);
            MariDiscordPermissionsUtils.SetValue(ref value, connect, MariDiscordGuildPermission.Connect);
            MariDiscordPermissionsUtils.SetValue(ref value, speak, MariDiscordGuildPermission.Speak);
            MariDiscordPermissionsUtils.SetValue(ref value, muteMembers, MariDiscordGuildPermission.MuteMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, deafenMembers, MariDiscordGuildPermission.DeafenMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, moveMembers, MariDiscordGuildPermission.MoveMembers);
            MariDiscordPermissionsUtils.SetValue(ref value, useVoiceActivation, MariDiscordGuildPermission.UseVAD);
            MariDiscordPermissionsUtils.SetValue(ref value, prioritySpeaker, MariDiscordGuildPermission.PrioritySpeaker);
            MariDiscordPermissionsUtils.SetValue(ref value, stream, MariDiscordGuildPermission.Stream);
            MariDiscordPermissionsUtils.SetValue(ref value, changeNickname, MariDiscordGuildPermission.ChangeNickname);
            MariDiscordPermissionsUtils.SetValue(ref value, manageNicknames, MariDiscordGuildPermission.ManageNicknames);
            MariDiscordPermissionsUtils.SetValue(ref value, manageRoles, MariDiscordGuildPermission.ManageRoles);
            MariDiscordPermissionsUtils.SetValue(ref value, manageWebhooks, MariDiscordGuildPermission.ManageWebhooks);
            MariDiscordPermissionsUtils.SetValue(ref value, manageEmojis, MariDiscordGuildPermission.ManageEmojis);

            RawValue = value;
        }

        /// <summary> 
        /// Creates a new <see cref="MariDiscordGuildPermissions"/> structure with the provided permissions. 
        /// </summary>
        public MariDiscordGuildPermissions(
            bool createInstantInvite = false,
            bool kickMembers = false,
            bool banMembers = false,
            bool administrator = false,
            bool manageChannels = false,
            bool manageGuild = false,
            bool addReactions = false,
            bool viewAuditLog = false,
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
            bool changeNickname = false,
            bool manageNicknames = false,
            bool manageRoles = false,
            bool manageWebhooks = false,
            bool manageEmojis = false)
            : this(0,
                createInstantInvite: createInstantInvite,
                manageRoles: manageRoles,
                kickMembers: kickMembers,
                banMembers: banMembers,
                administrator: administrator,
                manageChannels: manageChannels,
                manageGuild: manageGuild,
                addReactions: addReactions,
                viewAuditLog: viewAuditLog,
                viewChannel: viewChannel,
                sendMessages: sendMessages,
                sendTTSMessages: sendTTSMessages,
                manageMessages: manageMessages,
                embedLinks: embedLinks,
                attachFiles: attachFiles,
                readMessageHistory: readMessageHistory,
                mentionEveryone: mentionEveryone,
                useExternalEmojis: useExternalEmojis,
                connect: connect,
                speak: speak,
                muteMembers: muteMembers,
                deafenMembers: deafenMembers,
                moveMembers: moveMembers,
                useVoiceActivation: useVoiceActivation,
                prioritySpeaker: prioritySpeaker,
                stream: stream,
                changeNickname: changeNickname,
                manageNicknames: manageNicknames,
                manageWebhooks: manageWebhooks,
                manageEmojis: manageEmojis)
        { }


        /// <summary> 
        /// Creates a new <see cref="MariDiscordGuildPermissions"/> from this one, changing the provided non-null permissions. 
        /// </summary>
        public IMariDiscordGuildPermissions Modify(
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
            bool? manageEmojis = null)
            => new MariDiscordGuildPermissions(RawValue, createInstantInvite, kickMembers, banMembers, administrator, manageChannels, manageGuild, addReactions,
                viewAuditLog, viewChannel, sendMessages, sendTTSMessages, manageMessages, embedLinks, attachFiles,
                readMessageHistory, mentionEveryone, useExternalEmojis, connect, speak, muteMembers, deafenMembers, moveMembers,
                useVoiceActivation, prioritySpeaker, stream, changeNickname, manageNicknames, manageRoles, manageWebhooks, manageEmojis);
    }
}