using System.Collections.Immutable;

namespace Learning.Controlling
{
    public class FightContext
    {
        private readonly ImmutableArray<PlayerCommand> _commands;

        public ImmutableArray<PlayerCommand> Commands => _commands;

        public FightContext(IEnumerable<PlayerCommand> commands)
        {
            _commands = commands.ToImmutableArray();
        }

        public IEnumerable<Player> GetEnemiesFor(Player player)
        {
            var playerCommand = _commands.FirstOrDefault(x => x.IsFromCommand(player) == true)
                ?? throw new Exception("Player has not command");

            var enemyCommands = _commands.Where(x => x != playerCommand);

            var enemies = _commands.SelectMany(x => x);
            return enemies;
        }
    }
}
