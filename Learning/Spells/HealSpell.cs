
namespace Learning.Spells
{
    public class HealSpell : ISpell
    {
        private const int _healCount = 12;

        public SpellTypes Type => SpellTypes.Support;

        public string Description => "Лечит на 12 единиц";

        public void Use(Creature executor, Creature victim)
        {
            victim.Heal(_healCount);
        }
    }
}
