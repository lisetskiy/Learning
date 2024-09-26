
using Learning.Items;
using System.Collections.Immutable;

namespace Learning.Buffs
{
    public class Inventory : IBuffProvider
    {
        private readonly ImmutableArray<IItem> _items;

        public Inventory(IEnumerable<IItem> items)
        {
            _items = items.ToImmutableArray();
        }

        public void ApplyBuff(CreatureState state)
        {
            foreach (var item in _items)
            {
                item.ApplyBuff(state);
            }
        }
    }
}
