using System;
using System.Threading.Tasks;
using MariGlobals.Event.Concrete;

namespace MariBot.DiscordPatterns.Websockets
{
    /// <summary>
    /// Base sharded socket client interface.
    /// </summary>
    public interface IMariDiscordSocketClient : IDisposable
    {
        /// <summary>
        /// When the entire lib as ready.
        /// </summary>
        event AsyncEventHandler OnReady;

        /// <summary>
        /// Total shard count of this sharded client.
        /// </summary>
        int TotalShardCount { get; }

        /// <summary>
        /// Login in discord.
        /// </summary>
        /// <param name="token">The bot token.</param>
        Task LoginAsync(string token);

        /// <summary>
        /// Start the entire lib.
        /// </summary>
        Task StartAsync();

        /// <summary>
        /// Logout in discord.
        /// </summary>
        Task LogoutAsync();

        /// <summary>
        /// Stop the entire lib.
        /// </summary>
        Task StopAsync();
    }
}