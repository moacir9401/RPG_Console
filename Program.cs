using RPG_Console.src.Entities;

Hero hero = new()
{
    Name = "Arua",
    Level = 23,
    HeroType = "Knight"
};

Wizard wizard = new()
{
    Name = "Jennica",
    Level = 23,
    HeroType = "White Wizard"
};


Console.WriteLine(wizard.Attack(1));
Console.WriteLine(wizard.Attack(7));