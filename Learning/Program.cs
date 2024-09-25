using Learning;
using Learning.Factories;

var factory = new CommandFactory();

var area = new FightArea(factory);
area.Run();