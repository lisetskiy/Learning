
namespace Learning.Controlling
{
    public interface IPlayerController
    {
        IFightAction? Controll(FightContext context, Player player);
    }
}
