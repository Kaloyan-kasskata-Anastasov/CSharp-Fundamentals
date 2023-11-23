/*
2
Solmyr 85 120
Kyrre 99 50
Heal - Solmyr - 10
Recharge - Solmyr - 50
TakeDamage - Kyrre - 66 - Orc
CastSpell - Kyrre - 15 - ViewEarth
End

4
Adela 90 150
SirMullich 70 40
Ivor 1 111
Heal - SirMullich - 50
Recharge - Adela - 100
CastSpell - Tyris - 1000 - Fireball
TakeDamage - Tyris - 99 - Fireball
TakeDamage - Ivor - 3 - Mosquito
End
 
*/


using System.Text;

class Hero
{
    public string Name;
    public int HP;
    public int MP;

    public Hero(string name, int hp, int mp)
    {
        Name = name;
        Heal(hp);
        Recharge(mp);
    }

    public int Heal(int hp)
    {
        int recoveredHP = Math.Min(hp, 100 - HP);
        HP += recoveredHP;

        return recoveredHP;
    }

    public int Recharge(int mp)
    {
        int recoveredMP = Math.Min(mp, 200 - MP);
        MP += recoveredMP;

        return recoveredMP;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Name);
        sb.AppendLine($"  HP: {HP}");
        sb.AppendLine($"  MP: {MP}");

        return sb.ToString();
    }
}

class Program
{
    static List<Hero> party = new List<Hero>();

    static void Main()
    {
        int heroesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < heroesCount; i++)
        {
            string[] heroArgs = Console.ReadLine().Split();
            Hero h = new Hero(heroArgs[0], int.Parse(heroArgs[1]), int.Parse(heroArgs[2]));
            party.Add(h);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split(" - ");

            switch (arguments[0])
            {
                case "CastSpell":
                    CastSpell(arguments[1], int.Parse(arguments[2]), arguments[3]);
                    break;
                case "TakeDamage":
                    TakeDamage(arguments[1], int.Parse(arguments[2]), arguments[3]);
                    break;
                case "Recharge":
                    Recharge(arguments[1], int.Parse(arguments[2]));
                    break;
                case "Heal":
                    Heal(arguments[1], int.Parse(arguments[2]));
                    break;
            }
        }

        party.ForEach(h => Console.Write(h));
    }

    static void CastSpell(string heroName, int neededMP, string spellName)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null && foundHero.MP >= neededMP)
        {
            foundHero.MP -= neededMP;
            Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.MP} MP!");
        }
        else
        {
            Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spellName}!");
        }
    }

    private static void TakeDamage(string heroName, int damage, string attacker)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null)
        {
            foundHero.HP -= damage;
        }

        if (foundHero.HP > 0)
        {
            Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attacker} and now has {foundHero.HP} HP left!");
        }
        else
        {
            party.Remove(foundHero);
            Console.WriteLine($"{foundHero.Name} has been killed by {attacker}!");
        }
    }

    private static void Recharge(string heroName, int mp)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null)
        {
            int recovered = foundHero.Recharge(mp);
            Console.WriteLine($"{foundHero.Name} recharged for {recovered} MP!");
        }
    }

    private static void Heal(string heroName, int hp)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null)
        {
            int recovered = foundHero.Heal(hp);
            Console.WriteLine($"{foundHero.Name} healed for {recovered} HP!");
        }
    }
}
