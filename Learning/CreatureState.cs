
namespace Learning
{
    public readonly struct ReadOnlyCreatureState
    {
        public float MaxHealth { get; init; }

        public float Damage { get; init; }

        public float Armor { get; init; }
    }

    public class CreatureState
    {
        private readonly ReadOnlyCreatureState _base;

        public float MaxHealth { get; set; }

        public float Damage { get; set; }

        public float Armor { get; set; }

        public CreatureState(ReadOnlyCreatureState @base)
        {
            _base = @base;
            Reset();
        }

        public void Reset()
        {
            MaxHealth = _base.MaxHealth;
            Damage = _base.Damage;
            Armor = _base.Armor;
        }
    }
}
