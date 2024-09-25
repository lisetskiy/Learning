
namespace Learning.Controlling
{
    public class AttackAction : IFightAction
    {
        private readonly Player _victim;

        public AttackAction(Player victim)
        {
            _victim = victim;
        }

        public void Execute(Player executor)
        {
            var state = executor.Creature.GetCurrentState();
            _victim.Creature.ApplyDamage(state.Damage);

            Console.WriteLine($"игрок {executor.Name} наносит {state.Damage} урона игроку {_victim.Name}");
            Thread.Sleep(2000);
        }
    }
}
