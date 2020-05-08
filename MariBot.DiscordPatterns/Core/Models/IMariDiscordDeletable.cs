using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Results;

namespace MariBot.DiscordPatterns.Core.Models
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