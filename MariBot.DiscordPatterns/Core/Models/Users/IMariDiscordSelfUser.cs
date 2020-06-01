using System;
using System.Threading.Tasks;
using MariBot.DiscordPatterns.Core.Models.Results;

namespace MariBot.DiscordPatterns.Core.Models.Users
{
    /// <summary>
    /// Represents the logged-in Discord user.
    /// </summary>
    public interface IMariDiscordSelfUser : IMariDiscordUser
    {
        /// <summary>
        /// The email associated with this user.
        /// </summary>
        string Email { get; }

        /// <summary>
        /// Indicates whether or not this user has their email verified.
        /// </summary>
        bool IsVerified { get; }

        /// <summary>
        /// Indicates whether or not this user has MFA enabled on their account.
        /// </summary>
        bool IsMfaEnabled { get; }

        /// <summary>
        /// The flags that are applied to a user's account.
        /// </summary>
        MariDiscordUserProperties Flags { get; }

        /// <summary>
        /// The type of Nitro subscription that is active on this user's account.
        /// </summary>
        MariDiscordPremiumType PremiumType { get; }

        /// <summary>
        /// The user's chosen language option.
        /// </summary>
        string Locale { get; }

        /// <summary>
        /// Modifies the user's properties.
        /// </summary>
        /// <param name="func">The delegate containing the properties to modify the user with.</param>
        Task<IMariDiscordRestResult> ModifyAsync(Action<MariDiscordSelfUserProperties> func);
    }
}