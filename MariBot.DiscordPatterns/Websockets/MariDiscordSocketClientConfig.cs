using Microsoft.Extensions.Logging;

namespace MariBot.DiscordPatterns.Websockets
{
    /// <inheritdoc />
    public class MariDiscordSocketClientConfig : IMariDiscordSocketClientConfig
    {

        /// <inheritdoc />
        public LogLevel LogLevel { get; set; } = LogLevel.Information;

        /// <inheritdoc />
        public int MessageCacheSize { get; set; } = 100;

        /// <inheritdoc />
        public int? ShardCount { get; set; }

        /// <inheritdoc />
        public int ConnectionTimeout { get; set; } = 10000;

        /// <inheritdoc />
        public bool AlwaysDownloadUsers { get; set; } = false;

        /// <inheritdoc />
        public int[] ShardIds { get; set; }
    }
}