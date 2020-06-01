using System;
using MariGlobals.Extensions;

// https://github.com/Quahu/Disqord/blob/3663f05cbd29b6a4847c70976692c330da6cc08b/src/Disqord.Core/Optional.cs
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

        /// <summary>
        /// Retrieves the value of this <see cref="MariDiscordOptional{T}"/>, or the 
        /// default value of <typeparamref name="T"/>.
        /// </summary>
        public T GetValueOrDefault()
            => HasValue
                ? _value
                : default;

        /// <summary>
        /// Checks whether this <see cref="MariDiscordOptional{T}"/> or this 
        /// <see cref="Value"/> are equal to the specified <see cref="object"/>.
        /// </summary>
        /// <param name="obj"> The <see cref="object"/> to compare against. </param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is T value)
                return Equals(value);

            if (obj is MariDiscordOptional<T> optional)
                return Equals(optional);

            return false;
        }

        /// <summary>
        /// Checks whether this <see cref="Value"/> is equal to the specified 
        /// <typeparamref name="T"/> value.
        /// </summary>
        /// <param name="other"> The <typeparamref name="T"/> value to compare against. </param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public bool Equals(T other)
        {
            if (!HasValue)
                return false;

            return ReferenceEquals(_value, other);
        }

        /// <summary>
        /// Checks whether this <see cref="Value"/> is equal to the specified 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="other"> The <see cref="MariDiscordOptional{T}"/> to compare against. </param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public bool Equals(MariDiscordOptional<T> other)
        {
            if (!HasValue && !other.HasValue)
                return true;

            if (HasValue != other.HasValue)
                return false;

            return _value.Equals(other._value);
        }

        /// <summary>
        /// Implicitly converts the <paramref name="value"/> to an 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="value"> The value to convert. </param>
        public static implicit operator MariDiscordOptional<T>(T value)
            => new MariDiscordOptional<T>(value);

        /// <summary>
        /// Implicitly gets the <see cref="MariDiscordOptional{T}.Value"/>.
        /// </summary>
        /// <param name="value"> The optional to get the value from. </param>
        /// <exception cref="InvalidOperationException">
        /// This optional doesn't have a value.
        /// </exception>
        public static explicit operator T(MariDiscordOptional<T> value)
            => value.Value;

        /// <summary>
        /// Checks if this <see cref="MariDiscordOptional{T}"/> is equal to another 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="left"> The left-hand side <see cref="MariDiscordOptional{T}"/>.</param>
        /// <param name="right"> The right-hand side <see cref="MariDiscordOptional{T}"/> 
        /// to compare against.</param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public static bool operator ==(MariDiscordOptional<T> left, MariDiscordOptional<T> right)
            => left.Equals(right);

        /// <summary>
        /// Checks if this <see cref="MariDiscordOptional{T}"/> isn't equal to another 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="left"> The left-hand side <see cref="MariDiscordOptional{T}"/>.</param>
        /// <param name="right"> The right-hand side <see cref="MariDiscordOptional{T}"/> 
        /// to compare against.</param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public static bool operator !=(MariDiscordOptional<T> left, MariDiscordOptional<T> right)
            => !left.Equals(right);

        /// <summary>
        /// Checks if this <see cref="MariDiscordOptional{T}"/> is equal to another 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="left"> The left-hand side <see cref="MariDiscordOptional{T}"/>.</param>
        /// <param name="right"> The right-hand side <see cref="MariDiscordOptional{T}"/> 
        /// to compare against.</param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>s
        public static bool operator ==(MariDiscordOptional<T> left, T right)
            => left.Equals(right);

        /// <summary>
        /// Checks if this <see cref="MariDiscordOptional{T}"/> isn't equal to another 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="left"> The left-hand side <see cref="MariDiscordOptional{T}"/>.</param>
        /// <param name="right"> The right-hand side <see cref="MariDiscordOptional{T}"/> 
        /// to compare against.</param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public static bool operator !=(MariDiscordOptional<T> left, T right)
            => !left.Equals(right);

        /// <summary>
        /// Checks if this <see cref="MariDiscordOptional{T}"/> is equal to another 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="left"> The left-hand side <see cref="MariDiscordOptional{T}"/>.</param>
        /// <param name="right"> The right-hand side <see cref="MariDiscordOptional{T}"/> 
        /// to compare against.</param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public static bool operator ==(T left, MariDiscordOptional<T> right)
            => right.Equals(left);

        /// <summary>
        /// Checks if this <see cref="MariDiscordOptional{T}"/> isn't equal to another 
        /// <see cref="MariDiscordOptional{T}"/>.
        /// </summary>
        /// <param name="left"> The left-hand side <see cref="MariDiscordOptional{T}"/>.</param>
        /// <param name="right"> The right-hand side <see cref="MariDiscordOptional{T}"/> 
        /// to compare against.</param>
        /// <returns>
        /// The <see cref="bool"/> value reresenting whether the comparison succeeded.
        /// </returns>
        public static bool operator !=(T left, MariDiscordOptional<T> right)
            => !right.Equals(left);
    }
}