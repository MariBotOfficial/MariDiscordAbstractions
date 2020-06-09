namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Properties that are used to reorder an <see cref="IMariDiscordRole"/>.
    /// </summary>
    public class MariDiscordReorderRoleProperties
    {
        /// <summary>
        /// The identifier of the role to be edited.
        /// </summary>
        public ulong Id { get; }

        /// <summary>
        /// The new zero-based position of the role.
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// Initializes a <see cref="MariDiscordReorderRoleProperties" /> with the given role ID and position.
        /// </summary>
        /// <param name="id">The ID of the role to be edited.</param>
        /// <param name="pos">The new zero-based position of the role.</param>
        public MariDiscordReorderRoleProperties(ulong id, int pos)
        {
            Id = id;
            Position = pos;
        }
    }
}