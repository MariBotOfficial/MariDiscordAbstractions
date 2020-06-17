namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a generic audit log entry.
    /// </summary>
    public interface IMariDiscordAuditLogEntry : IMariDiscordSnowFlakeEntity
    {
        /// <summary>
        /// The action which occurred to create this entry.
        /// </summary>
        MariDiscordActionType Action { get; }

        /// <summary>
        /// The data for this entry.
        /// </summary>
        IMariDiscordAuditLogData Data { get; }

        /// <summary>
        /// The user responsible for causing the changes.
        /// </summary>
        IMariDiscordUser User { get; }

        /// <summary>
        /// The reason behind the change.
        /// </summary>
        string Reason { get; }
    }
}