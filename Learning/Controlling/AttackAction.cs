
namespace Learning.Controlling
{
    public class AttackAction : IFightAction
    {
        private readonly Creature _victim;

        public AttackAction(Creature victim)
        {
            _victim = victim;
        }

        public void Execute(Creature executor)
        {
            _victim.ApplyDamage(executor);
        }
    }
}
