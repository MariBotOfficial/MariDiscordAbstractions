using System;

namespace MariBot.DiscordPatterns
{
    /// <inheritdoc />
    public class MariDiscordCustomEmote : IMariDiscordCustomEmote
    {
        /// <inheritdoc />
        public bool Animated { get; }

        /// <inheritdoc />
        public string Url
            => MariDiscordCDNUtils.GetEmojiUrl(Id, Animated);

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public DateTimeOffset CreatedAt
            => MariDiscordSnowFlakeUtils.FromSnowflake(Id);

        /// <inheritdoc />
        public ulong Id { get; }

        /// <summary>
        /// Creates an instance of <see cref="MariDiscordCustomEmote" />
        /// </summary>
        /// <param name="id">The unique identifier of this emote.</param>
        /// <param name="name">The name of this emote.</param>
        /// <param name="animated">Whether this emote is animated or not.</param>
        public MariDiscordCustomEmote(ulong id, string name, bool animated)
        {
            Id = id;
            Name = name;
            Animated = animated;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj == this)
                return true;

            var emote = obj as IMariDiscordCustomEmote;

            if (emote == null)
                return false;

            return Id == emote.Id;
        }

        /// <inheritdoc />
        public override int GetHashCode()
            => Id.GetHashCode();

        /// <summary>
        /// Returns the raw representation of the emote.
        /// </summary>
        public override string ToString()
            => $"<{(Animated ? "a" : "")}:{Name}:{Id}>";
    }
}