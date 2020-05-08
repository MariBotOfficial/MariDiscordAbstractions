namespace MariBot.DiscordPatterns.Core.Models.Results
{
    /// <summary>
    ///  Represents a Mari rest discord result.
    /// </summary>
    public interface IMariDiscordRestResult : IMariDiscordResult
    {
        /// <summary>
        /// The status code of this request.
        /// </summary>
        int StatusCode { get; }
    }

    /// <inheritdoc/>
    public interface IMariDiscordRestResult<TValue> : IMariDiscordRestResult
        where TValue : IMariDiscordEntity<ulong>
    {
        /// <summary>
        /// The value of the request.
        /// </summary>
        TValue Value { get; }
    }
}