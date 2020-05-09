using System;
using System.Drawing;

// Copied from https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Entities/Roles/Color.cs
// I copied that because I really like use the default colors set xD.

namespace MariBot.DiscordPatterns.Core.Models
{
    /// <summary>
    /// Represents a color used in Discord.
    /// </summary>
    public readonly struct MariDiscordColor
    {
        /// <summary> The default user color value. </summary>
        public static readonly MariDiscordColor Default = new MariDiscordColor(0);

        /// <summary> The teal color value. </summary>
        public static readonly MariDiscordColor Teal = new MariDiscordColor(0x1ABC9C);

        /// <summary> The dark teal color value. </summary>
        public static readonly MariDiscordColor DarkTeal = new MariDiscordColor(0x11806A);

        /// <summary> The green color value. </summary>
        public static readonly MariDiscordColor Green = new MariDiscordColor(0x2ECC71);

        /// <summary> The dark green color value. </summary>
        public static readonly MariDiscordColor DarkGreen = new MariDiscordColor(0x1F8B4C);

        /// <summary> The blue color value. </summary>
        public static readonly MariDiscordColor Blue = new MariDiscordColor(0x3498DB);

        /// <summary> The dark blue color value. </summary>
        public static readonly MariDiscordColor DarkBlue = new MariDiscordColor(0x206694);

        /// <summary> The purple color value. </summary>
        public static readonly MariDiscordColor Purple = new MariDiscordColor(0x9B59B6);

        /// <summary> The dark purple color value. </summary>
        public static readonly MariDiscordColor DarkPurple = new MariDiscordColor(0x71368A);

        /// <summary> The magenta color value. </summary>
        public static readonly MariDiscordColor Magenta = new MariDiscordColor(0xE91E63);

        /// <summary> The dark magenta color value. </summary>
        public static readonly MariDiscordColor DarkMagenta = new MariDiscordColor(0xAD1457);

        /// <summary> The gold color value. </summary>
        public static readonly MariDiscordColor Gold = new MariDiscordColor(0xF1C40F);

        /// <summary> The light orange color value. </summary>
        public static readonly MariDiscordColor LightOrange = new MariDiscordColor(0xC27C0E);

        /// <summary> The orange color value. </summary>
        public static readonly MariDiscordColor Orange = new MariDiscordColor(0xE67E22);

        /// <summary> The dark orange color value. </summary>
        public static readonly MariDiscordColor DarkOrange = new MariDiscordColor(0xA84300);

        /// <summary> The red color value. </summary>
        public static readonly MariDiscordColor Red = new MariDiscordColor(0xE74C3C);

        /// <summary> The dark red color value. </summary>
        public static readonly MariDiscordColor DarkRed = new MariDiscordColor(0x992D22);

        /// <summary> The light grey color value. </summary>
        public static readonly MariDiscordColor LightGrey = new MariDiscordColor(0x979C9F);

        /// <summary> The lighter grey color value. </summary>
        public static readonly MariDiscordColor LighterGrey = new MariDiscordColor(0x95A5A6);

        /// <summary> The dark grey color value. </summary>
        public static readonly MariDiscordColor DarkGrey = new MariDiscordColor(0x607D8B);

        /// <summary> The darker grey color value. </summary>
        public static readonly MariDiscordColor DarkerGrey = new MariDiscordColor(0x546E7A);

        /// <summary> The encoded value for this color. </summary>
        public uint RawValue { get; }

        /// <summary> The red component for this color. </summary>
        public byte R => (byte)(RawValue >> 16);

        /// <summary> The green component for this color. </summary>
        public byte G => (byte)(RawValue >> 8);

        /// <summary> The blue component for this color. </summary>
        public byte B => (byte)(RawValue);

        /// <summary>
        ///  Initializes a <see cref="Color"/> struct with the given raw value.
        /// </summary>
        /// <param name="rawValue">The raw value of the color (e.g. <c>0x607D8B</c>).</param>
        public MariDiscordColor(uint rawValue)
        {
            RawValue = rawValue;
        }

        /// <summary>
        /// Initializes a <see cref="Color" /> struct with the given RGB bytes.
        /// </summary>
        /// <param name="r">The byte that represents the red color.</param>
        /// <param name="g">The byte that represents the green color.</param>
        /// <param name="b">The byte that represents the blue color.</param>
        public MariDiscordColor(byte r, byte g, byte b)
        {
            RawValue =
                ((uint)r << 16) |
                ((uint)g << 8) |
                (uint)b;
        }

        /// <summary>
        /// Initializes a <see cref="Color"/> struct with the given RGB value.
        /// </summary>
        /// <param name="r">The value that represents the red color. Must be within 0~255.</param>
        /// <param name="g">The value that represents the green color. Must be within 0~255.</param>
        /// <param name="b">The value that represents the blue color. Must be within 0~255.</param>
        /// <exception cref="ArgumentOutOfRangeException">The argument value is not between 0 to 255.</exception>
        public MariDiscordColor(int r, int g, int b)
        {
            if (r < 0 || r > 255)
                throw new ArgumentOutOfRangeException(nameof(r), "Value must be within [0,255].");

            if (g < 0 || g > 255)
                throw new ArgumentOutOfRangeException(nameof(g), "Value must be within [0,255].");

            if (b < 0 || b > 255)
                throw new ArgumentOutOfRangeException(nameof(b), "Value must be within [0,255].");

            RawValue =
                ((uint)r << 16) |
                ((uint)g << 8) |
                (uint)b;
        }

        /// <summary>
        ///     Initializes a <see cref="Color"/> struct with the given RGB float value.
        /// </summary>
        /// <param name="r">The value that represents the red color. Must be within 0~1.</param>
        /// <param name="g">The value that represents the green color. Must be within 0~1.</param>
        /// <param name="b">The value that represents the blue color. Must be within 0~1.</param>
        /// <exception cref="ArgumentOutOfRangeException">The argument value is not between 0 to 1.</exception>
        public MariDiscordColor(float r, float g, float b)
        {
            if (r < 0.0f || r > 1.0f)
                throw new ArgumentOutOfRangeException(nameof(r), "Value must be within [0,1].");

            if (g < 0.0f || g > 1.0f)
                throw new ArgumentOutOfRangeException(nameof(g), "Value must be within [0,1].");

            if (b < 0.0f || b > 1.0f)
                throw new ArgumentOutOfRangeException(nameof(b), "Value must be within [0,1].");

            RawValue =
                ((uint)(r * 255.0f) << 16) |
                ((uint)(g * 255.0f) << 8) |
                (uint)(b * 255.0f);
        }

        /// <summary>
        /// Equals operator.
        /// </summary>
        public static bool operator ==(MariDiscordColor lhs, MariDiscordColor rhs)
            => lhs.RawValue == rhs.RawValue;

        /// <summary>
        /// Diferrent operator.
        /// </summary>
        public static bool operator !=(MariDiscordColor lhs, MariDiscordColor rhs)
            => lhs.RawValue != rhs.RawValue;

        /// <inheritdoc/>
        public override bool Equals(object obj)
            => (obj is MariDiscordColor c && RawValue == c.RawValue);

        /// <inheritdoc/>
        public override int GetHashCode() => RawValue.GetHashCode();

        /// <summary>
        /// Compares with <see cref="Color" />.
        /// </summary>
        public static implicit operator Color(MariDiscordColor color) =>
            Color.FromArgb((int)color.RawValue);

        /// <summary>
        /// Compares with <see cref="Color" />.
        /// </summary>
        public static explicit operator MariDiscordColor(Color color) =>
            new MariDiscordColor((uint)color.ToArgb() << 8 >> 8);

        /// <summary>
        /// The hexadecimal representation of the color (e.g. <c>#000ccc</c>).
        /// </summary>
        /// <returns>
        ///  A hexadecimal string of the color.
        /// </returns>
        public override string ToString() =>
            string.Format("#{0:X6}", RawValue);
    }
}