
namespace Learning.Factories
{
    public interface ICommandFactory
    {
        IEnumerable<PlayerCommand> Build();
    }
}
