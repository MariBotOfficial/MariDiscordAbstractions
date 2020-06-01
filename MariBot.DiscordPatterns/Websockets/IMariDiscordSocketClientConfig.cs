using Microsoft.Extensions.Logging;

namespace MariBot.DiscordPatterns.Websockets
{
    /// <summary>
    /// Base socket client configuration.
    /// </summary>
    public interface IMariDiscordSocketClientConfig
    {
        /// <summary>
        /// The base Discord CDN URL. 
        /// </summary>
        const string CDNUrl
            = "https://cdn.discordapp.com/";

        /// <summary>
        /// LogLevel for entire logging.
        /// </summary>
        LogLevel LogLevel { get; set; }

        /// <summary>
        /// Total message cache size.
        /// </summary>
        int MessageCacheSize { get; set; }

        /// <summary>
        /// Total shard count.
        /// </summary>
        int? ShardCount { get; set; }

        /// <summary>
        /// Connection timeout.
        /// </summary>
        int ConnectionTimeout { get; set; }

        /// <summary>
        ///  Gets or sets whether or not all users should be downloaded as guilds come available.
        /// </summary>
        bool AlwaysDownloadUsers { get; set; }

        /// <summary>
        /// The shard ids of this sharded client.
        /// </summary>
        int[] ShardIds { get; set; }

        /// <summary>
        /// If true all subscribers this event will invokes concurrently, default is true.
        /// </summary>
        bool InvokeEventsConcurrently { get; set; }

        /// <summary>
        ///  If false and <see cref="InvokeEventsConcurrently" /> true this event will wait all invokes finishes, default is false.
        /// </summary>
        bool WaitForAllEvents { get; set; }
    }
}