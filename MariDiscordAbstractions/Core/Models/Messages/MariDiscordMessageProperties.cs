namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Properties that are used to modify an <see cref="IMariDiscordUserMessage" /> 
    /// with the specified changes.
    /// </summary>
    public class MariDiscordMessageProperties
    {
        /// <summary>
        /// The content of the message.
        /// </summary>
        MariDiscordOptional<string> Content { get; set; }

        /// <summary>
        /// The embed the message should display.
        /// </summary>
        MariDiscordOptional<IMariDiscordEmbed> Embed { get; set; }
    }
}