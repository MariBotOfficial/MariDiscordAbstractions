using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic channel that can send and receive messages.
    /// </summary>
    public interface IMariDiscordMessageChannel : IMariDiscordChannel
    {
        /// <summary>
        /// Sends a message to this message channel.
        /// </summary>
        /// <param name="text">The message to be sent.</param>
        /// <param name="isTTS">Whether the message should be read aloud by Discord or not.</param>
        /// <param name="embed">The <see cref="IMariDiscordEmbed"/> to be sent.</param>
        /// <param name="allowedMentions">Specifies if notifications are sent for mentioned users 
        /// and roles in the message <paramref name="text"/>.
        /// If <c>null</c>, all mentioned roles and users will be notified.</param>
        Task<IMariDiscordRestResult<IMariDiscordUserMessage>> SendMessageAsync(string text = null, bool isTTS = false, IMariDiscordEmbed embed = null, IMariDiscordAllowedMentions allowedMentions = null);

        /// <summary>
        /// Sends a file to this message channel.
        /// </summary>
        /// <param name="stream">The <see cref="Stream" /> of the file to be sent.</param>
        /// <param name="fileName">The name of the attachment.</param>
        /// <param name="text">The message to be sent.</param>
        /// <param name="isTTS">Whether the message should be read aloud by Discord or not.</param>
        /// <param name="embed">The <see cref="IMariDiscordEmbed"/> to be sent.</param>
        /// <param name="isSpoiler">Whether the message attachment should be hidden as a spoiler.</param>
        Task<IMariDiscordRestResult<IMariDiscordUserMessage>> SendFileAsync(Stream stream, string fileName, string text = null, bool isTTS = false, IMariDiscordEmbed embed = null, bool isSpoiler = false);

        /// <summary>
        /// Sends a file to this message channel.
        /// </summary>
        /// <param name="filePath">The file path of the file.</param>
        /// <param name="fileName">The name of the attachment.</param>
        /// <param name="text">The message to be sent.</param>
        /// <param name="isTTS">Whether the message should be read aloud by Discord or not.</param>
        /// <param name="embed">The <see cref="IMariDiscordEmbed"/> to be sent.</param>
        /// <param name="isSpoiler">Whether the message attachment should be hidden as a spoiler.</param>
        Task<IMariDiscordRestResult<IMariDiscordUserMessage>> SendFileAsync(string filePath, string fileName, string text = null, bool isTTS = false, IMariDiscordEmbed embed = null, bool isSpoiler = false)
        {
            var filename = Path.GetFileName(filePath);

            using var file = File.OpenRead(filePath);

            return SendFileAsync(file, fileName, text, isTTS, embed, isSpoiler);
        }

        /// <summary>
        /// Gets a message from this message channel.
        /// </summary>
        /// <param name="id">The snowflake identifier of the message.</param>
        Task<IMariDiscordRestResult<IMariDiscordMessage>> GetMessageAsync(ulong id);

        /// <summary>
        /// Gets a collection of messages in this channel.
        /// </summary>
        /// <param name="limit">The numbers of message to be gotten from.</param>
        IAsyncEnumerable<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordMessage>>> GetMessagesAsync(int limit = 100);

        /// <summary>
        /// Gets a collection of messages in this channel.
        /// </summary>
        /// <param name="fromMessageId">The ID of the starting message to get the messages from.</param>
        /// <param name="direction">The direction of the messages to be gotten from.</param>
        /// <param name="limit">The numbers of message to be gotten from.</param>
        IAsyncEnumerable<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordMessage>>> GetMessagesAsync(ulong fromMessageId, MariDiscordDirection direction, int limit = 100);

        /// <summary>
        /// Gets a collection of messages in this channel.
        /// </summary>
        /// <param name="fromMessage">The starting message to get the messages from.</param>
        /// <param name="direction">The direction of the messages to be gotten from.</param>
        /// <param name="limit">The numbers of message to be gotten from.</param>
        IAsyncEnumerable<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordMessage>>> GetMessagesAsync(IMariDiscordMessage fromMessage, MariDiscordDirection direction, int limit = 100)
            => GetMessagesAsync(fromMessage.Id, direction, limit);

        /// <summary>
        /// Gets a collection of pinned messages in this channel.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordMessage>>> GetPinnedMessagesAsync();

        /// <summary>
        /// Deletes a message.
        /// </summary>
        /// <param name="messageId">The snowflake identifier of the message that would be removed.</param>
        Task<IMariDiscordRestResult> DeleteMessageAsync(ulong messageId);

        /// <summary>
        /// Deletes a message based on the provided message in this channel.
        /// </summary>
        /// <param name="message">The message that would be removed.</param>
        Task<IMariDiscordRestResult> DeleteMessageAsync(IMariDiscordMessage message)
            => DeleteMessageAsync(message.Id);

        /// <summary>
        /// Broadcasts the "user is typing" message to all users in this channel, lasting 10? seconds.
        /// </summary>
        Task<IMariDiscordRestResult> TriggerTypingAsync();

        /// <summary>
        /// Continuously broadcasts the "user is typing" message to all users in this channel 
        /// until the returned object is disposed.
        /// </summary>
        IDisposable EnterTypingState();
    }
}