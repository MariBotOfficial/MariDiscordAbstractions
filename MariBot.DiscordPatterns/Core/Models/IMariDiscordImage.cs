using System;
using System.IO;

namespace MariBot.DiscordPatterns.Core.Models
{
    /// <summary>
    /// An image that will be uploaded to Discord.
    /// </summary>
    public interface IMariDiscordImage : IDisposable
    {
        /// <summary>
        /// Gets the stream to be uploaded to Discord.
        /// </summary>
        Stream Stream { get; }
    }
}