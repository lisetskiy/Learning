
using Learning.Controlling;
using Learning.Factories;
using System.Numerics;

namespace Learning
{
    public class FightArea
    {
        private readonly ICommandFactory _factory;

        public FightArea(ICommandFactory factory)
        {
            _factory = factory;
        }

        public void Run()
        {
            var commands = _factory.Build();
            var context = new FightContext(commands);

            bool isRunning = true;

            while (isRunning == true)
            {
                isRunning = Update(context);
            }
        }

        private bool Update(FightContext context)
        {
            foreach (var command in context.Commands)
            {
                foreach (var player in command)
                    HandlePlayerStep(player, command, context);
            }

            var aliveCommands = context.Commands.Where(x => x.IsAlive() == true);

            if (aliveCommands.Count() == 1)
            {
                var alive = aliveCommands.First();
                alive.WriteFromCommand($"команда {alive.Name} победила!");

                return false;
            }

            return true;
        }

        private void HandlePlayerStep(Player player, PlayerCommand command, FightContext context)
        {
            IFightAction? action = null;

            while (action == null)
            {
                Console.Clear();

                if (player.Creature.IsDead == true)
                    return;

                command.WriteFromCommand($"Очередь игрока {player.Name}");
                action = player.Controller.Controll(context, player);

                if (action != null)
                    ExecuteAction(action, player);
            }
        }

        private void ExecuteAction(IFightAction action, Player executor)
        {
            Console.Clear();
            action?.Execute(executor);
        }
    }
}
