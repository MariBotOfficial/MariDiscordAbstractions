using MariBot.DiscordPatterns.Core.Models;

namespace MariBot.DiscordPatterns.Core.Factories
{
    /// <summary>
    /// Represents a factory for create and manipulate <see cref="IMariDiscordSnowFlakeEntity" /> entities.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMariDiscordFactory<T>
        where T : IMariDiscordSnowFlakeEntity
    {

    }
}