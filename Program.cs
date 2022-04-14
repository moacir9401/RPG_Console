using RPG_Console.src.Entities;

Hero hero = new()
{
    Name = "Arua",
    Level = 42,
    HeroType = "Knight"
};

Wizard wizardWhite = new()
{
    Name = "Jennica",
    Level = 23,
    HeroType = "White Wizard"
};

Wizard wizardBlack = new()
{
    Name = "Topapa",
    Level = 42,
    HeroType = "Black Wizard"
};

Hero ninja = new()
{
    Name = "Wedge",
    Level = 23,
    HeroType = "Ninja"
};

Console.WriteLine(wizardWhite.Attack(1));
Console.WriteLine(wizardWhite.Attack(7));
Console.WriteLine(wizardBlack.Attack(7));
Console.WriteLine(ninja.Attack());