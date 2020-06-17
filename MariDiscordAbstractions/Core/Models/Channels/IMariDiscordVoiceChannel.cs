using System;
using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic voice channel in a guild.
    /// </summary>
    public interface IMariDiscordVoiceChannel : IMariDiscordNestedChannel
    {
        /// <summary>
        /// The bit-rate that the clients in this voice channel are requested to use.
        /// </summary>
        int Bitrate { get; }

        /// <summary>
        /// The max number of users allowed to be connected to this channel at once.
        /// </summary>
        int? UserLimit { get; }

        /// <summary>
        /// Modifies this voice channel.
        /// </summary>
        /// <param name="func">The properties to modify the channel with.</param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordVoiceChannelProperties> func);
    }
}