
namespace Learning.Spells
{
    public interface ISpell
    {
        SpellTypes Type { get; }

        string Description { get; }

        void Use(Creature executor, Creature victim);
    }

    public enum SpellTypes
    {
        Attack,
        Support
    }
}