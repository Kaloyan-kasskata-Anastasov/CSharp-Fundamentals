/*
1050
200
450
2
18.50 
16.86 
special
*/

class Program
{
    static void Main()
    {
        decimal totalPrice = 0;
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "special" || input == "regular")
            {
                break;
            }

            decimal price = decimal.Parse(input);

            if (price < 0)
            {
                Console.WriteLine("Invalid price!");
                continue;
            }

            totalPrice += price;
            //decimal tax = priceWithTaxes - price;
        }

        if (totalPrice == 0)
        {
            Console.WriteLine("Invalid order!");
        }
        else
        {
            decimal taxes = (totalPrice * (20m / 100m));

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");

            decimal totalPriceWithTaxes = totalPrice + taxes;
            if (input == "special")
            {
                totalPriceWithTaxes -= (totalPriceWithTaxes * 10m) / 100m;
            }

            Console.WriteLine($"Total price: {totalPriceWithTaxes:F2}$");
        }
    }
}
