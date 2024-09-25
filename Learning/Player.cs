
using Learning.Controlling;

namespace Learning
{
    public record Player(string Name, Creature Creature, IPlayerController Controller);
}
