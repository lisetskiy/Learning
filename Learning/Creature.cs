
using Learning.Buffs;

namespace Learning
{
    public class Creature
    {
        private readonly CreatureState _state;
        private readonly Inventory _inventory;
       // private readonly BuffContainer _buffs;
        
        public float Health { get; private set; }

        public bool IsDead => Health <= 0;

        public Creature(ReadOnlyCreatureState baseState, Inventory inventory)
        {
            _state = new CreatureState(baseState);
            _inventory = inventory;

            Health = _state.MaxHealth;
        }

        public void ApplyDamage(float damage)
        {
            var state = GetCurrentState();

            var totalDamage = Math.Max(damage - state.Armor, 1);
            Health -= damage;
        }

        public void Heal(float value)
        {
            if (value < 0)
                return;

            var state = GetCurrentState();
            Health = Math.Max(Health + value, state.MaxHealth);
        }

        public ReadOnlyCreatureState GetCurrentState()
        {
            _state.Reset();
            _inventory.ApplyBuff(_state);
            return _state.ToReadOnly();
        }
    }
}
