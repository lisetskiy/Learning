
using Learning.Controlling;
using Learning.Factories;

namespace Learning
{
    public class FightArea
    {
        private readonly ICommandFactory _factory;

        public FightArea(ICommandFactory factory)
        {
            _factory = factory;
        }

        public void Run()
        {
            var commands = _factory.Build();
            var context = new FightContext(commands);

            while (true)
            {
                Update(context);
            }
        }

        private void Update(FightContext context)
        {
            foreach (var command in context.Commands)
        }
    }
}
