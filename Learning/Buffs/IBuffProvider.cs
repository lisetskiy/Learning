
namespace Learning.Buffs
{
    public interface IBuffProvider
    {
        void ApplyBuff(CreatureState state, Creature creature);
    }
}
