

using Learning.Buffs;
using Learning.Controlling;
using Learning.Items;

namespace Learning.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private static readonly ReadOnlyCreatureState _enemyState = new(200000, 1, 5);
        private static readonly ReadOnlyCreatureState _playerState = new(100, 2, 7);

        public IEnumerable<PlayerCommand> Build()
        {
            var command1 = new PlayerCommand("ТАРАС 40.000", ConsoleColor.Cyan);
            var command2 = new PlayerCommand("ПМИК-32", ConsoleColor.Green);

            for (int i = 0; i < 1; i++)
            {
                var enemy = CreateEnemy("Тарас Великий Босс" + i);
                command1.AddPlayer(enemy);
            }

            command2.AddPlayer(CreatePlayer("Максим Великий"));
            command2.AddPlayer(CreatePlayer("Вещий Вадим"));
            command2.AddPlayer(CreatePlayer("Артём Неуловимый"));

            yield return command1;
            yield return command2;
        }

        private Player CreateEnemy(string name)
        {
            var items = new IItem[]
            {
                new Weapon("2кг меч", 1, 3)
            };

            var creature = new Creature(_enemyState, new Inventory(items));
            var player = new Player(name, creature, new ComputerController());

            return player;
        }

        private Player CreatePlayer(string name)
        {
            var items = new IItem[]
            {
                new Weapon("12кг меч", 66, 2000)
            };

            var creature = new Creature(_playerState, new Inventory(items));
            var player = new Player(name, creature, new PlayerController());

            return player;
        }
    }
}
