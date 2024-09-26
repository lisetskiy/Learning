
using Learning.Spells;

namespace Learning.Controlling
{
    public class SpellAction : IFightAction
    {
        private readonly Creature _victim;
        private readonly ISpell _spell;

        public SpellAction(Creature victim, ISpell spell)
        {
            _victim = victim;
            _spell = spell;
        }

        public void Execute(Creature executor)
        {
            _spell.Use(executor, _victim);
        }
    }
}
