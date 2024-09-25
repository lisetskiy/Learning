
namespace Learning.Controlling
{
    public class ComputerController : IPlayerController
    {
        public IFightAction? Controll(FightContext context, Player player)
        {
            Thread.Sleep(1000);
            return EmptyAction.Instance;
        }
    }
}
