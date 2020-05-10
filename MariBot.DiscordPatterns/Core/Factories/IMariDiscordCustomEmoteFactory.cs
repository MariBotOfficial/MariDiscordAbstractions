using System;
using MariBot.DiscordPatterns.Core.Models.Emotes;

namespace MariBot.DiscordPatterns.Core.Factories
{
    /// <summary>
    /// A factory for create and manipulate <see cref ="IMariDiscordCustomEmote" /> entities.
    /// </summary>
    public interface IMariDiscordCustomEmoteFactory
        : IMariDiscordFactory<IMariDiscordCustomEmote>
    {

        /// <summary> Parses an <see cref="IMariDiscordCustomEmoteFactory"/> from its raw format.
        /// </summary>
        /// <param name="text">The raw encoding of an emote; for example, &lt;:dab:277855270321782784&gt;.
        /// </param>
        /// <returns>
        /// An instance of <see cref="IMariDiscordCustomEmote" />.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Invalid emote format.
        /// </exception>
        IMariDiscordCustomEmote Parse(string text)
        {
            if (TryParse(text, out var result))
                return result;

            throw new ArgumentException("Invalid emote format.", nameof(text));
        }

        /// <summary> 
        /// Tries to parse an <see cref="IMariDiscordCustomEmoteFactory"/> from its raw format. 
        /// </summary>
        /// <param name="text">
        /// The raw encoding of an emote; for example, &lt;:dab:277855270321782784&gt;.
        /// </param>
        /// <param name="result">
        /// An emote.
        /// </param>
        bool TryParse(string text, out IMariDiscordCustomEmote result);
    }
}