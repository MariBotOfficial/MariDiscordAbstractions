namespace MariBot.DiscordPatterns
{
    /// <summary>
    /// Represents the type of the object in an <see cref="IMariDiscordTag" />
    /// </summary>
    public enum MariDiscordTagType
    {
        /// <summary> 
        /// The object is an user mention. 
        /// </summary>
        UserMention,

        /// <summary> 
        /// The object is a channel mention. 
        /// </summary>
        ChannelMention,

        /// <summary> 
        /// The object is a role mention. 
        /// </summary>
        RoleMention,

        /// <summary> 
        /// The object is an everyone mention. 
        /// </summary>
        EveryoneMention,

        /// <summary> 
        /// The object is a here mention. 
        /// </summary>
        HereMention,

        /// <summary> 
        /// The object is an emoji. 
        /// </summary>
        Emoji
    }
}