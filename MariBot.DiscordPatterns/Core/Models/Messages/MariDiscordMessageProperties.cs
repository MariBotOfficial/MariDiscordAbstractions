namespace MariBot.DiscordPatterns.Core.Models.Messages
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
        string Content { get; set; }

        /// <summary>
        /// The embed the message should display.
        /// </summary>
        IMariDiscordEmbed Embed { get; set; }
    }
}