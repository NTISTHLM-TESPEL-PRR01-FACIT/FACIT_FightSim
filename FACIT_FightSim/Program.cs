using System;

int heroHp = 100;
int villainHp = 100;

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
  Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
  Console.WriteLine($"HERO: {heroHp}  VILLAIN: {villainHp}\n");

  int heroDamage = generator.Next(20);
  villainHp -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"HERO gör {heroDamage} skada på VILLAIN");

  int villainDamage = generator.Next(20);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"VILLAIN gör {villainDamage} skada på HERO");

  Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (heroHp == 0)
{
  Console.WriteLine("VILLAIN vann!");
}
else
{
  Console.WriteLine("HERO vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();