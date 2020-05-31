using System.Collections.Generic;
using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Invites;
using MariBot.DiscordPatterns.Core.Models.Results;

namespace MariBot.DiscordPatterns.Core.Models.Channels
{
    /// <summary>
    /// Represents a type of guild channel that can be nested within a category.
    /// </summary>
    public interface IMariDiscordNestedChannel : IMariDiscordGuildChannel
    {
        /// <summary>
        /// The parent (category) ID of this channel in the guild's channel list.
        /// </summary>
        ulong? CategoryId { get; }

        /// <summary>
        /// The parent (category) channel of this channel.
        /// </summary>
        Task<IMariDiscordRestResult<IMariDiscordCategoryChannel>> GetCategoryAsync();

        /// <summary>
        /// Syncs the permissions of this nested channel with its parent's.
        /// </summary>
        Task<IMariDiscordRestResult> SyncPermissionsAsync();

        /// <summary>
        /// Creates a new invite to this channel.
        /// </summary>
        /// <param name="maxAge">The time (in seconds) until the invite expires. Set to <c>null</c> to never expire.</param>
        /// <param name="maxUses">The max amount of times this invite may be used. Set to <c>null</c> to have unlimited uses.</param>
        /// <param name="isTemporary">If <c>true</c>, the user accepting this invite will be kicked from the guild after closing their client.</param>
        /// <param name="isUnique">If <c>true</c>, don't try to reuse a similar invite (useful for creating many unique one time use invites).</param>
        Task<IMariDiscordInviteMetadata> CreateInviteAsync(int? maxAge = 86400, int? maxUses = default(int?), bool isTemporary = false, bool isUnique = false);

        /// <summary>
        /// Gets a collection of all invites to this channel.
        /// </summary>
        Task<IMariDiscordRestResult<IReadOnlyCollection<IMariDiscordInviteMetadata>>> GetInvitesAsync();
    }
}