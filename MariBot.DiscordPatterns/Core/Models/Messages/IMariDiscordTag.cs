namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents an object mention or a <see cref="IMariDiscordEmote" /> 
    /// in a <see cref="IMariDiscordMessage" />.
    /// </summary>
    public interface IMariDiscordTag
    {
        /// <summary>
        /// The index of this tag.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// The length of this tag.
        /// </summary>
        int Length { get; }

        /// <summary>
        /// The type of this tag.
        /// </summary>
        MariDiscordTagType Type { get; }

        /// <summary>
        /// The id of the referenced object.
        /// </summary>
        ulong Key { get; }

        /// <summary>
        /// The value of the referenced object.
        /// </summary>
        object Value { get; }
    }
}