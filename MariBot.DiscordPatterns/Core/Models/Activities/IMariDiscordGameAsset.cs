namespace MariBot.DiscordPatterns.Core.Models.Activities
{
    /// <summary>
    /// Represents an asset for a <see cref="IMariDiscordRichGame" /> object containing the text and image.
    /// </summary>
    public interface IMariDiscordGameAsset
    {
        /// <summary>
        /// The application ID for the game.
        /// </summary>
        ulong? ApplicationId { get; }

        /// <summary>
        /// The description of the asset.
        /// </summary>
        string Text { get; }

        /// <summary>
        /// The image ID of the asset.
        /// </summary>
        string ImageId { get; }

        /// <summary>
        /// Returns the image URL of the asset.
        /// </summary>
        /// <param name="format">The size of the image to return in. This can be any power of two between 16 and 2048.</param>
        /// <param name="size">The format to return.</param>
        string GetImageUrl(MariDiscordImageFormat format = MariDiscordImageFormat.Auto, ushort size = 128);
    }
}