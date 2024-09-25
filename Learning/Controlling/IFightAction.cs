

namespace Learning.Controlling
{
    public interface IFightAction
    {
        void Execute(Player executor);
    }

    public class EmptyAction : IFightAction
    {
        public static readonly EmptyAction Instance = new();

        private EmptyAction()
        {
        }

        public void Execute(Player executor)
        {
            Console.WriteLine($"{executor.Name} пропускает ход");
            Thread.Sleep(1000);
        }
    }
}
