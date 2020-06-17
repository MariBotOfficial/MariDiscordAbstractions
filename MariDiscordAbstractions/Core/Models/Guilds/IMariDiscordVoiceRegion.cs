namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents a region of which the user connects to when using voice.
    /// </summary>    
    public interface IMariDiscordVoiceRegion
    {
        /// <summary>
        /// Gets the unique identifier for this voice region.
        /// </summary>        
        string Id { get; }

        /// <summary>
        /// Gets the name of this voice region.
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets a value that indicates whether or not this voice region is exclusive to partnered servers.
        /// </summary>        
        bool IsVip { get; }

        /// <summary>
        /// Gets a value that indicates whether this voice region is optimal for your client in terms of latency.
        /// </summary>        
        bool IsOptimal { get; }

        /// <summary>
        /// Gets a value that indicates whether this voice region is no longer being maintained.
        /// </summary>        
        bool IsDeprecated { get; }

        /// <summary>
        /// Gets a value that indicates whether this voice region is custom-made for events.
        /// </summary>
        bool IsCustom { get; }
    }
}