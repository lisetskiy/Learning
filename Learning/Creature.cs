
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
            Health = _state.MaxHealth;
        }

        public void ApplyDamage(float damage)
        {
            var state = GetCurrentState();

            var totalDamage = Math.Max(damage - state.Armor, 1);
            Health -= damage;
        }

        public ReadOnlyCreatureState GetCurrentState()
        {
            return _state.ToReadOnly();
        }
    }
}
