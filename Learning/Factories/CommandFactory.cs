

using Learning.Controlling;

namespace Learning.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private static readonly ReadOnlyCreatureState _enemyState = new(200, 1, 5);
        private static readonly ReadOnlyCreatureState _playerState = new(100, 2, 7);

        public IEnumerable<PlayerCommand> Build()
        {
            var command1 = new PlayerCommand("Команда Тарасов", ConsoleColor.Red);
            var command2 = new PlayerCommand("Комманда героев", ConsoleColor.Green);

            for (int i = 0; i < 10; i++)
            {
                var enemy = CreateEnemy("Тарас" + i);
                command1.AddPlayer(enemy);
            }

            command2.AddPlayer(CreatePlayer("Игрок1"));
            command2.AddPlayer(CreatePlayer("Игрок2"));

            yield return command1;
            yield return command2;
        }

        private Player CreateEnemy(string name)
        {
            var creature = new Creature(_enemyState);
            var player = new Player(name, creature, new ComputerController());

            return player;
        }

        private Player CreatePlayer(string name)
        {
            var creature = new Creature(_playerState);
            var player = new Player(name, creature, new PlayerController());

            return player;
        }
    }
}
