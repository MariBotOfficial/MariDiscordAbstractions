using System;
using MariGlobals.Extensions;

namespace MariBot.DiscordPatterns.Core.Models
{
    /// <summary>
    /// Represents an optional value from discord.
    /// OBS: This is not the same of <see cref="Nullable{T}" />.
    /// </summary>
    /// <typeparam name="T">The type of the optional value.</typeparam>
    public readonly struct MariDiscordOptional<T>
    {
        /// <summary>
        /// An instance of <see cref="MariDiscordOptional{T}" /> without value.
        /// </summary>
        public static readonly MariDiscordOptional<T> Empty = new MariDiscordOptional<T>();

        private readonly T _value;

        /// <summary>
        /// The value for this parameter.
        /// </summary>
        public T Value
        {
            get => HasValue
                ? _value
                : throw new InvalidOperationException("This optional does not have a value.");
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HasValue { get; }

        /// <summary>
        /// Creates a new instance of <see cref="MariDiscordOptional{T}" /> with the provided
        /// value.
        /// </summary>
        /// <param name="value">The value of this optional.</param>
        public MariDiscordOptional(T value)
        {
            _value = value;
            HasValue = true;
        }

        /// <inheritdoc />
        public override int GetHashCode()
            => HasValue
                ? _value.GetHashCode()
                : -1;

        /// <inheritdoc />
        public override string ToString()
            => HasValue
                ? _value?.ToString() ?? $"{null}"
                : $"{null}";
    }
}