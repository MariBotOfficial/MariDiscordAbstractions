using System;
using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Results;

namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents a generic message sent by a user.
    /// </summary>
    public interface IMariDiscordUserMessage : IMariDiscordMessage
    {
        /// <summary>
        /// Modifies this message.
        /// </summary>
        /// <param name="func">
        /// A delegate containing the properties to modify the message with.
        /// </param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordMessageProperties> func);

        /// <summary>
        /// Modifies the suppression of this message.
        /// </summary>
        /// <param name="suppressEmbeds">
        /// Whether or not embeds in this message should be suppressed.
        /// </param>
        Task<IMariDiscordRestResult> ModifySuppressionAsync(bool suppressEmbeds);

        /// <summary>
        /// Pin this message to channel's pinned messages.
        /// </summary>
        Task<IMariDiscordRestResult> PinAsync();

        /// <summary>
        /// Unpin this message to channel's pinned messages.
        /// </summary>
        Task<IMariDiscordRestResult> UnpinAsync();

        /// <summary>
        /// Transforms this message's text into a human-readable form by resolving its tags.
        /// </summary>
        /// <param name="userHandling">Determines how the user tag should be handled.</param>
        /// <param name="channelHandling">Determines how the channel tag should be handled.</param>
        /// <param name="roleHandling">Determines how the role tag should be handled.</param>
        /// <param name="everyoneHandling">Determines how the @everyone tag should be handled.</param>
        /// <param name="emojiHandling">Determines how the emoji tag should be handled.</param>
        string Resolve(
            MariDiscordTagHandling userHandling = MariDiscordTagHandling.Name,
            MariDiscordTagHandling channelHandling = MariDiscordTagHandling.Name,
            MariDiscordTagHandling roleHandling = MariDiscordTagHandling.Name,
            MariDiscordTagHandling everyoneHandling = MariDiscordTagHandling.Ignore,
            MariDiscordTagHandling emojiHandling = MariDiscordTagHandling.Name);
    }
}