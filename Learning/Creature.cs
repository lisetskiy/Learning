
namespace Learning
{
    public class Creature
    {
        private readonly CreatureState _state;
        
        public float Health { get; private set; }

        public bool IsDead => Health <= 0;

        public Creature(ReadOnlyCreatureState baseState)
        {
            _state = new CreatureState(baseState);
        }

        public void ApplyDamage(Creature attacker)
        {

        }
    }
}
