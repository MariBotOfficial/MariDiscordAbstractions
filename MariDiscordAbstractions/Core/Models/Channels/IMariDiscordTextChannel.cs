using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic channel in a guild that can send and receive messages.
    /// </summary>
    public interface IMariDiscordTextChannel : IMariDiscordMessageChannel, IMariDiscordMentionable, IMariDiscordNestedChannel
    {
        /// <summary>
        /// Gets a value that indicates whether the channel is NSFW.
        /// </summary>
        bool IsNsfw { get; }

        /// <summary>
        /// Gets the current topic for this text channel.
        /// </summary>
        string Topic { get; }

        /// <summary>
        /// Gets the current slow-mode delay for this channel.
        /// </summary>
        int SlowModeInterval { get; }

        /// <summary>
        /// Bulk-deletes multiple messages.
        /// </summary>
        /// <param name="messages">The messages to be bulk-deleted.</param>
        Task<IMariDiscordRestResult> DeleteMessagesAsync(IEnumerable<IMariDiscordMessage> messages)
            => DeleteMessagesAsync(messages.Select(a => a.Id).ToList());

        /// <summary>
        /// Bulk-deletes multiple messages.
        /// </summary>
        /// <remarks>
        /// This method attempts to remove the messages specified in bulk.
        /// <note type="important">
        /// Due to the limitation set by Discord, this method can only remove messages that are posted within 14 days!
        /// </note>
        /// </remarks>
        /// <param name="messageIds">The snowflake identifier of the messages to be bulk-deleted.</param>
        Task<IMariDiscordRestResult> DeleteMessagesAsync(IEnumerable<ulong> messageIds);

        /// <summary>
        /// Modifies this text channel.
        /// </summary>
        /// <param name="func">The delegate containing the properties to modify the channel with.</param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordTextChannelProperties> func);

        /// <summary>
        /// Creates a webhook in this text channel.
        /// </summary>
        /// <param name="name">The name of the webhook.</param>
        /// <param name="avatar">The avatar of the webhook.</param>
        Task<IMariDiscordRestResult<IMariDiscordWebhook>> CreateWebhookAsync(string name, Stream avatar = null);

        /// <summary>
        /// Gets a webhook available in this text channel.
        /// </summary>
        /// <param name="id">The identifier of the webhook.</param>
        Task<IMariDiscordRestResult<IMariDiscordWebhook>> GetWebhookAsync(ulong id);

        /// <summary>
        /// Gets the webhooks available in this text channel.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordWebhook>>> GetWebhooksAsync();
    }
}