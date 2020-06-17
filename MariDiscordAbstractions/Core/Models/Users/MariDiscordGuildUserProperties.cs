using System.Collections.Generic;

namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Properties that are used to modify an <see cref="IMariDiscordGuildUser" /> with the following parameters.
    /// </summary>
    public class MariDiscordGuildUserProperties
    {
        /// <summary>
        /// Gets or sets whether the user should be muted in a voice channel.
        /// </summary>
        public MariDiscordOptional<bool> Mute { get; set; }

        /// <summary>
        /// Gets or sets whether the user should be deafened in a voice channel.
        /// </summary>
        public MariDiscordOptional<bool> Deaf { get; set; }

        /// <summary>
        /// Gets or sets the user's nickname.
        /// </summary>
        public MariDiscordOptional<string> Nickname { get; set; }

        /// <summary>
        /// Gets or sets the roles the user should have.
        /// </summary>
        public MariDiscordOptional<IEnumerable<IMariDiscordRole>> Roles { get; set; }

        /// <summary>
        /// Gets or sets the roles the user should have.
        /// </summary>
        public MariDiscordOptional<IEnumerable<ulong>> RoleIds { get; set; }

        /// <summary>
        /// Moves a user to a voice channel. If <c>null</c>, this user will be disconnected from their current voice channel.
        /// </summary>
        public MariDiscordOptional<IMariDiscordVoiceChannel> Channel { get; set; }

        /// <summary>
        /// Moves a user to a voice channel. Set <see cref="Channel"/> to <c>null</c> to disconnect this user from their current voice channel.
        /// </summary>
        public MariDiscordOptional<ulong?> ChannelId { get; set; }
    }
}