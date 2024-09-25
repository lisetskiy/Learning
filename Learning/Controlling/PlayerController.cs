
namespace Learning.Controlling
{
    public class PlayerController : IPlayerController
    {
        public IFightAction? Controll(FightContext context, Player player)
        {
            Console.WriteLine("1: удар");
            Console.WriteLine("2: заклинание");
            Console.WriteLine("3: пропустить ход");

            var input = Console.ReadLine();
            var result = int.TryParse(input, out int index);

            if (result == false)
                return null;

            if (index == 1)
            {
                return HandleAttack();
            }
            else if (index == 3)
            {
                return Actions.Pass();
            }
            else
            {
                return null;
            }
        }

        private IFightAction? HandleAttack()
        {
            return null;
        }
    }
}
