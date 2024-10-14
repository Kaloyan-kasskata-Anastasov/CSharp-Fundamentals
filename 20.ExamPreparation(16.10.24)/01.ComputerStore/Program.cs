class Program
{
    static void Main()
    {
        decimal total = 0;
        decimal taxes = 0;

        decimal taxRate = 0.20m;
        decimal specialDiscountRate = 0.10m;

        string input;
        while ((input = Console.ReadLine()) != "special" && input != "regular")
        {
            decimal partPrice = decimal.Parse(input);

            if (partPrice <= 0)
            {
                Console.WriteLine("Invalid price!");
                continue;
            }

            total += partPrice;
            taxes += partPrice * taxRate;
        }

        if (total == 0)
        {
            Console.WriteLine("Invalid order!");
        }
        else
        {
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {total:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");
            
            if (input == "special")
            {
                total -= (total + taxes) * specialDiscountRate;
            }
       
            Console.WriteLine($"Total price: {total + taxes:F2}$");
        }
    }
}
