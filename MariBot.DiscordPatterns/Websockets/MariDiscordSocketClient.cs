using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Messages;
using MariGlobals.Event.Concrete;
using Microsoft.Extensions.Logging;

namespace MariBot.DiscordPatterns.Websockets
{
    /// <inheritdoc />
    public abstract class MariDiscordSocketClient : IMariDiscordSocketClient
    {
        /// <summary>
        /// Returns if this current instance is disposed.
        /// </summary>
        public bool IsDisposed { get; protected set; } = false;

        /// <summary>
        /// The logger of this client.
        /// </summary>
        protected readonly ILogger<IMariDiscordSocketClient> _logger;

        /// <inheritdoc />
        public event AsyncEventHandler OnReady
        {
            add => _onReady.Register(value);
            remove => _onReady.Unregister(value);
        }

        /// <summary>
        /// Invokes the <see cref="OnReady" /> event.
        /// </summary>
        protected readonly AsyncEvent _onReady;

        /// <summary>
        /// Config for this client.
        /// </summary>
        protected IMariDiscordSocketClientConfig Config { get; set; }

        /// <summary>
        /// Total shard count of this sharded client.
        /// </summary>
        public int TotalShardCount { get; protected set; }

        /// <summary>
        /// Creates a new instance of <see cref="MariDiscordSocketClient" />
        /// </summary>
        /// <param name="config">Configuration for this client.</param>
        /// <param name="logger">The logger of this client. </param>
        public MariDiscordSocketClient(
            IMariDiscordSocketClientConfig config,
            ILogger<IMariDiscordSocketClient> logger)
        {
            Config = config;
            TotalShardCount = config.ShardIds?.Length ?? 1;


            _logger = logger;
            _onReady = new AsyncEvent();
        }

        /// <summary>
        /// Creates a new instance of <see cref="MariDiscordSocketClient" />
        /// <param name="config">Configuration for this client.</param>
        /// </summary>
        public MariDiscordSocketClient(IMariDiscordSocketClientConfig config)
            : this(config, null) { }

        /// <summary>
        /// Creates a new instance of <see cref="MariDiscordSocketClient" />
        /// </summary>
        public MariDiscordSocketClient()
            : this(new MariDiscordSocketClientConfig(), null) { }

        /// <inheritdoc />
        public abstract Task LoginAsync(string token);

        /// <inheritdoc />
        public abstract Task StartAsync();

        /// <inheritdoc />
        public abstract Task LogoutAsync();

        /// <inheritdoc />
        public abstract Task StopAsync();

        /// <inheritdoc />
        public abstract void Dispose();
    }
}