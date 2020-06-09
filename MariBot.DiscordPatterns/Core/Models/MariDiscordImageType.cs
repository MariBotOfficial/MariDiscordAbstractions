namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents the type of format the image should return in.
    /// </summary>
    public enum MariDiscordImageFormat
    {
        /// <summary>
        /// Use automatically detected format.
        /// </summary>
        Auto,

        /// <summary>
        ///  Use Google's WebP image format.
        /// </summary>
        WebP,

        /// <summary>
        /// Use PNG.
        /// </summary>
        Png,

        /// <summary>
        /// Use JPEG.
        /// </summary>
        Jpeg,

        /// <summary>
        /// Use GIF.
        /// </summary>
        Gif,
    }
}