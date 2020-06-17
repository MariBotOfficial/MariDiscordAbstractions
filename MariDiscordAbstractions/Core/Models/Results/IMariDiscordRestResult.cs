using System.Net;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    ///  Represents a Mari rest discord result.
    /// </summary>
    public interface IMariDiscordRestResult : IMariDiscordResult
    {
        /// <summary>
        /// The status code of this request.
        /// </summary>
        HttpStatusCode StatusCode { get; }
    }

    /// <inheritdoc />
    public interface IMariDiscordRestResult<TValue> : IMariDiscordRestResult
    {
        /// <summary>
        /// The value of the request.
        /// </summary>
        TValue Value { get; }
    }
}