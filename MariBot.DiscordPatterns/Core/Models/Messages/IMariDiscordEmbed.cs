using System;
using System.Collections.Generic;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a Discord's embed.
    /// </summary>
    public interface IMariDiscordEmbed
    {
        /// <summary>
        /// The title URL of this embed.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// The title of this embed.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// The description of this embed.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The type of this embed.
        /// </summary>
        MariDiscordEmbedType Type { get; }

        /// <summary>
        /// The timestamp of this embed.
        /// </summary>
        DateTimeOffset? TimeStamp { get; }

        /// <summary>
        /// The color of this embed.
        /// </summary>
        IMariDiscordColor Color { get; }

        /// <summary>
        /// The image of this embed.
        /// </summary>
        IMariDiscordEmbedImage Image { get; }

        /// <summary>
        /// The video of this embed.
        /// </summary>
        IMariDiscordEmbedVideo Video { get; }

        /// <summary>
        /// The author of this embed.
        /// </summary>
        IMariDiscordEmbedAuthor Author { get; }

        /// <summary>
        /// The footer of this embed.
        /// </summary>
        IMariDiscordEmbedFooter Footer { get; }

        /// <summary>
        /// The provider of this embed.
        /// </summary>
        IMariDiscordEmbedProvider Provider { get; }

        /// <summary>
        /// The thumbnail of this embed.
        /// </summary>
        IMariDiscordEmbedThumbnail Thumbnail { get; }

        /// <summary>
        /// The fields of this embed.
        /// </summary>
        IReadOnlyCollection<IMariDiscordEmbedField> Fields { get; }
    }
}