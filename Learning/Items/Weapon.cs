
namespace Learning.Items
{
    public class Weapon : IItem
    {
        public string Name { get; }

        public int MinDamage { get; }

        public int MaxDamage { get; }

        public Action? Action { get; }

        public Weapon(string name, int minDamage, int maxDamage, Action? action = null)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Action = action;
        }

        public void ApplyBuff(CreatureState state)
        {
            state.Damage += Random.Shared.Next(MinDamage, MaxDamage);
            Action?.Invoke();
        }
    }
}
