
namespace Learning.Items
{
    public interface IItem
    {
        string Name { get; }

        void ApplyBuff(CreatureState state);
    }
}
