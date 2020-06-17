// Copied from https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Entities/Roles/Color.cs
// I copied that because I really like use the default colors set xD.

namespace MariBot.DiscordPatterns
{

    /// <summary>
    /// Represents a color in discord.
    /// </summary>
    public interface IMariDiscordColor
    {
        /// <summary> 
        /// The default user color value. 
        /// </summary>
        static readonly IMariDiscordColor Default
            = new MariDiscordColor(0);

        /// <summary> 
        /// The teal color value. 
        /// </summary>
        static readonly IMariDiscordColor Teal
            = new MariDiscordColor(0x1ABC9C);

        /// <summary> 
        /// The dark teal color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkTeal
            = new MariDiscordColor(0x11806A);

        /// <summary> 
        /// The green color value. 
        /// </summary>
        static readonly IMariDiscordColor Green
            = new MariDiscordColor(0x2ECC71);

        /// <summary> 
        /// The dark green color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkGreen
            = new MariDiscordColor(0x1F8B4C);

        /// <summary> 
        /// The blue color value. 
        /// </summary>
        static readonly IMariDiscordColor Blue
            = new MariDiscordColor(0x3498DB);

        /// <summary> 
        /// The dark blue color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkBlue
            = new MariDiscordColor(0x206694);

        /// <summary> 
        /// The purple color value. 
        /// </summary>
        static readonly IMariDiscordColor Purple
            = new MariDiscordColor(0x9B59B6);

        /// <summary> 
        /// The dark purple color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkPurple
            = new MariDiscordColor(0x71368A);

        /// <summary> 
        /// The magenta color value. 
        /// </summary>
        static readonly IMariDiscordColor Magenta
            = new MariDiscordColor(0xE91E63);

        /// <summary> 
        /// The dark magenta color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkMagenta
            = new MariDiscordColor(0xAD1457);

        /// <summary> 
        /// The gold color value. 
        /// </summary>
        static readonly IMariDiscordColor Gold
            = new MariDiscordColor(0xF1C40F);

        /// <summary> 
        /// The light orange color value. 
        /// </summary>
        static readonly IMariDiscordColor LightOrange
            = new MariDiscordColor(0xC27C0E);

        /// <summary> 
        /// The orange color value. 
        /// </summary>
        static readonly IMariDiscordColor Orange
            = new MariDiscordColor(0xE67E22);

        /// <summary> 
        /// The dark orange color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkOrange
            = new MariDiscordColor(0xA84300);

        /// <summary> 
        /// The red color value. 
        /// </summary>
        static readonly IMariDiscordColor Red
            = new MariDiscordColor(0xE74C3C);

        /// <summary> 
        /// The dark red color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkRed
            = new MariDiscordColor(0x992D22);

        /// <summary> 
        /// The light grey color value. 
        /// </summary>
        static readonly IMariDiscordColor LightGrey
            = new MariDiscordColor(0x979C9F);

        /// <summary> 
        /// The lighter grey color value. 
        /// </summary>
        static readonly IMariDiscordColor LighterGrey
            = new MariDiscordColor(0x95A5A6);

        /// <summary> 
        /// The dark grey color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkGrey
            = new MariDiscordColor(0x607D8B);

        /// <summary> 
        /// The darker grey color value. 
        /// </summary>
        static readonly IMariDiscordColor DarkerGrey
            = new MariDiscordColor(0x546E7A);

        /// <summary> 
        /// The encoded value for this color. 
        /// </summary>
        uint RawValue { get; }

        /// <summary> 
        /// The red component for this color. 
        /// </summary>
        byte R => (byte)(RawValue >> 16);

        /// <summary> 
        /// The green component for this color. 
        /// </summary>
        byte G => (byte)(RawValue >> 8);

        /// <summary> 
        /// The blue component for this color. 
        /// </summary>
        byte B => (byte)(RawValue);
    }
}