using System;

/*
0.1, 0.2, 0.5, 1 and 2
Cannot accept {money}
*/
internal class Program
{
    static void Main(string[] args)
    {
        double balance = 0;

        // accumulates coins
        string command;
        command = Console.ReadLine();
        while (command != "Start")
        {
            double coin = double.Parse(command);
            if (coin == 0.1 ||
                coin == 0.2 ||
                coin == 0.5 ||
                coin == 1 ||
                coin == 2)
            {
                balance += coin;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coin}");
            }

            command = Console.ReadLine();
        }

        // Buying
        //"Nuts" with a price of 2.0
        //"Water" with a price of 0.7
        //"Crisps" with a price of 1.5
        //"Soda" with a price of 0.8
        //"Coke" with a price of 1.0
        //"Purchased {product name}"
        // "Sorry, not enough money"
        // "End"
        /*
1
1
0.5
0.6
Start
Coke
Soda
Crisps
End

1
Start
Nuts
Coke
End

        */
        double nutsPrice = 2;
        double waterPrice = 0.7;
        double crispsPrice = 1.5;
        double sodaPrice = 0.8;
        double cokePrice = 1.0;

        command = Console.ReadLine();
        while (command != "End")
        {
            switch (command)
            {
                case "Nuts":
                    if (balance >= nutsPrice)
                    {
                        balance -= nutsPrice;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                    break;
                case "Water":
                    if (balance >= waterPrice)
                    {
                        balance -= waterPrice;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                    break;
                case "Crisps":
                    if (balance >= crispsPrice)
                    {
                        balance -= crispsPrice;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                    break;
                case "Soda":
                    if (balance >= sodaPrice)
                    {
                        balance -= sodaPrice;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                    break;
                case "Coke":
                    if (balance >= cokePrice)
                    {
                        balance -= cokePrice;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid product");
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Change: {balance:F2}");
    }
}
