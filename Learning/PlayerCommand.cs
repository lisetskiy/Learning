
using System.Collections;

namespace Learning
{
    public class PlayerCommand : IEnumerable<Player>
    {
        private readonly string _name;
        private readonly ConsoleColor _color;
        private readonly List<Player> _players;

        public ConsoleColor Color => _color;

        public string Name => _name;

        public PlayerCommand(string name, ConsoleColor color)
        {
            _name = name;
            _color = color;
            _players = new();
        }

        public void AddPlayer(Player player)
        {
            if (player == null)
                return;

            if (_players.Contains(player) == true)
                return;

            _players.Add(player);
        }

        public bool IsFromCommand(Player player)
        {
            return _players.Contains(player);
        }

        public bool IsAlive()
        {
            var alive = _players.FirstOrDefault(x => x.Creature.IsDead == false);

            return alive != null;
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return _players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _players.GetEnumerator();
        }
    }
}
