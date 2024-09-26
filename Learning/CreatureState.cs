

namespace Learning
{
    public readonly struct ReadOnlyCreatureState
    {
        public float MaxHealth { get; init; }

        public float Damage { get; init; }

        public float Armor { get; init; }

        public ReadOnlyCreatureState(float maxHealth, float damage, float armor)
        {
            MaxHealth = maxHealth;
            Damage = damage;
            Armor = armor;
        }
    }

    public class CreatureState
    {
        private readonly ReadOnlyCreatureState _base;

        public float MaxHealth { get; }

        public float Damage { get; set; }

        public float Armor { get; set; }

        public CreatureState(ReadOnlyCreatureState @base)
        {
            _base = @base;
            Reset();
        }

        public void Reset()
        {
            Damage = _base.Damage;
            Armor = _base.Armor;
        }

        public ReadOnlyCreatureState ToReadOnly()
        {
            return new ReadOnlyCreatureState
            {
                MaxHealth = MaxHealth,
                Armor = Armor,
                Damage = Damage
            };
        }
    }
}
