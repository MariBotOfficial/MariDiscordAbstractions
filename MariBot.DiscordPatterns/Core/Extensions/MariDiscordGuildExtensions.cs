using MariBot.DiscordPatterns.Core.Models.Guilds;

namespace MariBot.DiscordPatterns.Core.Extensions
{
    /// <summary>
    /// An extension class for <see cref="IMariDiscordGuild"/>.
    /// </summary>
    public static class MariDiscordGuildExtensions
    {
        /// <summary>
        /// Gets if welcome system messages are enabled.
        /// </summary>
        /// <param name="guild"> The guild to check. </param>
        /// <returns> A <c>bool</c> indicating if the welcome messages are enabled in the system channel. </returns>
        public static bool GetWelcomeMessagesEnabled(this IMariDiscordGuild guild)
            => !guild.SystemChannelFlags.HasFlag(MariDiscordSystemChannelMessageDeny.WelcomeMessage);

        /// <summary>
        /// Gets if guild boost system messages are enabled.
        /// </summary>
        /// <param name="guild"> The guild to check. </param>
        /// <returns> A <c>bool</c> indicating if the guild boost messages are enabled in the system channel. </returns>
        public static bool GetGuildBoostMessagesEnabled(this IMariDiscordGuild guild)
            => !guild.SystemChannelFlags.HasFlag(MariDiscordSystemChannelMessageDeny.GuildBoost);
    }
}