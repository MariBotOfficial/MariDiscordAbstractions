namespace MariBot.DiscordPatterns.Websockets
{
    /// <summary>
    /// Base socket client.
    /// </summary>
    public abstract class MariDiscordSocketClient : IMariDiscordSocketClient
    {
        /// <summary>
        /// Creates a new instance of <see cref="MariDiscordSocketClient" />
        /// </summary>
        /// <param name="config">Configuration for this client.</param>
        public MariDiscordSocketClient(IMariDiscordSocketClientConfig config)
        {

        }

        /// <summary>
        /// Creates a new instance of <see cref="MariDiscordSocketClient" />
        /// </summary>
        /// <param name="config">Configuration for this client.</param>
        /// <param name="ids">Shards ids for this sharded client. </param>
        public MariDiscordSocketClient(int[] ids, IMariDiscordSocketClientConfig config)
        {
            
        }

        /// <inheritdoc/>
        public void Dispose()
        {
        }
    }
}