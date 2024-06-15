/*
100
10
10
10
1
2
3
73
10

200
54
14
28
13
End of battle
*/

class Program
{
    static void Main()
    {
        int energy = int.Parse(Console.ReadLine());
        int wins = 0;

        string command;
        while ((command = Console.ReadLine()) != "End of battle")
        {
            int distance = int.Parse(command);

            if (energy < distance)
            {
                Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                break;
            }

            wins++;
            energy -= distance;

            if (wins % 3 == 0)
            {
                energy += wins;
            }

            //Console.WriteLine($"Energy left: {energy}");
        }

        if (command == "End of battle")
        {
            Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        }
    }
}
