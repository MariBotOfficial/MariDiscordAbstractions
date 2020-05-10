// See Discord.NET for more details: https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Entities/Messages/TagHandling.cs

namespace MariBot.DiscordPatterns.Core.Models.Messages
{
    /// <summary>
    /// Specifies the handling type the tag should use.
    /// </summary>
    public enum MariDiscordTagHandling
    {
        /// <summary> 
        /// Tag handling is ignored.
        /// </summary>
        Ignore = 0,


        /// <summary> 
        /// Removes the tag entirely. 
        /// </summary>
        Remove,

        /// <summary> 
        /// Resolves to username. 
        /// </summary>
        Name,

        /// <summary> 
        /// Resolves to username without mention prefix. 
        /// </summary>
        NameNoPrefix,

        /// <summary> 
        /// Resolves to username with discriminator value.
        /// </summary>
        FullName,

        /// <summary> 
        /// Resolves to username with discriminator value without mention prefix.
        /// </summary>
        FullNameNoPrefix,

        /// <summary> 
        /// Sanitizes the tag.
        /// </summary>
        Sanitize
    }
}