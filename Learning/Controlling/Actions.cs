using Learning.Spells;

namespace Learning.Controlling
{
    public static class Actions
    {
        public static IFightAction Attack(Creature victim)
        {
            return new AttackAction(victim);
        }

        public static IFightAction UseSpell(Creature victim, ISpell spell)
        {
            return null;
        }

        public static IFightAction Pass()
        {
            return EmptyAction.Instance;
        }
    }
}
