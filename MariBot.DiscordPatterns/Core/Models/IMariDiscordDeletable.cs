using System.Threading.Tasks;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a entity that can be deleted.
    /// </summary>
    public interface IMariDiscordDeletable
    {
        /// <summary>
        /// Delete this entity.
        /// </summary>
        /// <returns>The result of this request.</returns>
        Task<IMariDiscordRestResult> DeleteAsync();
    }
}