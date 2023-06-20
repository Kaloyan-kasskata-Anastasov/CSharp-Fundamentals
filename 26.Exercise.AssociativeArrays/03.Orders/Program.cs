/*
Beer 2.20 100
IceTea 1.50 50
NukaCola 3.30 80
Water 1.00 500
buy

Beer 2.40 350
Water 1.25 200
IceTea 5.20 100
Beer 1.20 200
IceTea 0.50 120
buy

CesarSalad 10.20 25
SuperEnergy 0.80 400
Beer 1.35 350
IceCream 1.50 25
buy
*/

internal class Product
{
    public string Name { get; }

    public decimal Price { get; set; }

    public decimal Quantity { get; set; }

    public Product(string name, decimal price, decimal quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void Update(decimal price, decimal quantity)
    {
        Price = price;
        Quantity += quantity;
    }

    public decimal TotalPrice => Price * Quantity;

    public override string ToString()
    {
        return $"{Name} -> {TotalPrice:F2}";
    }
}

internal class Program
{
    static void Main()
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string command;
        while ((command = Console.ReadLine()) != "buy")
        {
            string[] arguments = command.Split();

            string name = arguments[0];
            decimal price = decimal.Parse(arguments[1]);
            decimal quantity = decimal.Parse(arguments[2]);

            Product product = new Product(name, price, quantity);

            if (!products.ContainsKey(name))
            {
                products.Add(name, product);
            }
            else
            {
                products[name].Update(price, quantity);
            }
        }

        foreach (KeyValuePair<string, Product> pair in products)
        {
            Console.WriteLine(pair.Value);
        }
    }
}
