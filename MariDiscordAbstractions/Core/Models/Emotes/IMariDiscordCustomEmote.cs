using System;
using System.Globalization;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a custom image-based emote.
    /// </summary>
    public interface IMariDiscordCustomEmote : IMariDiscordEmote, IMariDiscordSnowFlakeEntity
    {
        /// <summary>
        /// Whether this emote is animated.
        /// </summary>
        bool Animated { get; }

        /// <summary>
        /// The url of the image of this emote.
        /// </summary>
        string Url { get; }

        /// <summary> Parses an <see cref="IMariDiscordCustomEmote"/> from its raw format. </summary>
        /// <param name="text">The raw encoding of an emote; for example, &lt;:dab:277855270321782784&gt;.</param>
        /// <returns>An emote.</returns>
        /// <exception cref="ArgumentException">Invalid emote format.</exception>
        static IMariDiscordCustomEmote Parse(string text)
        {
            if (TryParse(text, out IMariDiscordCustomEmote result))
                return result;

            throw new ArgumentException("Invalid emote format.", nameof(text));
        }

        /// <summary> Tries to parse an <see cref="IMariDiscordCustomEmote"/> from its raw format. </summary>
        /// <param name="text">The raw encoding of an emote; for example, &lt;:dab:277855270321782784&gt;.</param>
        /// <param name="result">An emote.</param>
        static bool TryParse(string text, out IMariDiscordCustomEmote result)
        {
            // Thanks for Discord.NET https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Entities/Emotes/Emote.cs
            result = null;

            if (text.Length >= 4 && text[0] == '<' && (text[1] == ':' || (text[1] == 'a' && text[2] == ':')) && text[text.Length - 1] == '>')
            {
                var animated = text[1] == 'a';
                var startIndex = animated ? 3 : 2;

                var splitIndex = text.IndexOf(':', startIndex);

                if (splitIndex == -1)
                    return false;

                if (!ulong.TryParse(text.Substring(splitIndex + 1, text.Length - splitIndex - 2), NumberStyles.None, CultureInfo.InvariantCulture, out ulong id))
                    return false;

                var name = text.Substring(startIndex, splitIndex - startIndex);

                result = new MariDiscordCustomEmote(id, name, animated);
                return true;
            }

            return false;
        }
    }
}