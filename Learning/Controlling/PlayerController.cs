
namespace Learning.Controlling
{
    public class PlayerController : IPlayerController
    {
        public IFightAction? Controll(FightContext context, Player player)
        {
            var state = player.Creature.GetCurrentState();
            Console.WriteLine($"Здоровье:[{player.Creature.Health}/{state.MaxHealth}]");
            Console.WriteLine("1: удар");
            Console.WriteLine("2: заклинание");
            Console.WriteLine("3: пропустить ход");

            var input = Console.ReadLine();
            var result = int.TryParse(input, out int index);

            if (result == false)
                return null;

            if (index == 1)
            {
                return HandleAttack(context, player);
            }
            else if (index == 2)
            {

            }
            else if (index == 3)
            {
                return Actions.Pass();
            }

            return null;
        }

        private IFightAction? HandleAttack(FightContext context, Player player)
        {
            Console.Clear();
            var enemies = context.GetEnemiesFor(player);
            int i = 0;

            foreach (var enemy in enemies)
            {
                var state = enemy.Creature.GetCurrentState();
                Console.WriteLine($"{i}: {enemy.Name} Здоровье:[{enemy.Creature.Health}/{state.MaxHealth}]");
                i++;
            }

            var input = Console.ReadLine();
            var result = int.TryParse(input, out int index);

            if (result == false)
                return null;

            var victim = enemies.ElementAtOrDefault(index);

            if (victim == null)
                return null;

            return Actions.Attack(victim);
        }
    }
}
