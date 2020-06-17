namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represent a permission object.
    /// </summary>
    public interface IMariDiscordOverwrite
    {
        /// <summary>
        /// The unique identifier for the object this overwrite is targeting.
        /// </summary>
        ulong TargetId { get; }
        /// <summary>
        /// The type of object this overwrite is targeting.
        /// </summary>
        MariDiscordPermissionTarget TargetType { get; }

        /// <summary>
        /// The permissions associated with this overwrite entry.
        /// </summary>
        IMariDiscordOverwritePermissions Permissions { get; }
    }
}