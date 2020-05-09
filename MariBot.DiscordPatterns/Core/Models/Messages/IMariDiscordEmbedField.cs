namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Represents a field for an <see cref="IMariDiscordEmbed"/>.
    /// </summary>
    public interface IMariDiscordEmbedField
    {
        /// <summary>
        /// The name of the field.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The value of the field.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// A value that indicates whether the field should be in-line with each other.
        /// </summary>
        bool Inline { get; }
    }
}