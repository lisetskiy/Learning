

namespace Learning.Controlling
{
    public interface IFightAction
    {
        void Execute(Creature executor);
    }

    public class EmptyAction : IFightAction
    {
        public static readonly EmptyAction Instance = new();

        private EmptyAction()
        {
        }

        public void Execute(Creature executor)
        {
        }
    }
}
