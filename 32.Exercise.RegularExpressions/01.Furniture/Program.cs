using System.Text.RegularExpressions;

/*
>>Chair<<412.23!3
>>Sofa<<500!5
>>Recliner<<<<!5
>>Bench<<230!10
>>>>>>Rocking chair<<!5
>>Bed<<700!5
Purchase
*/

public class Furniture
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal Total
    {
        get { return Price * Quantity; }
    }
}

internal class Program
{
    static void Main()
    {
    
        List<Furniture> furnitures = new List<Furniture>();

        string pattern = @">>([A-z]+)<<(\d+\.\d+|\d+)!(\d+)";

        string command;
        while ((command = Console.ReadLine()) != "Purchase")
        {
            foreach (Match m in Regex.Matches(command, pattern))
            {
                Furniture furniture = new Furniture();
                furniture.Name = m.Groups[1].Value;
                furniture.Price = decimal.Parse(m.Groups[2].Value);
                furniture.Quantity = int.Parse(m.Groups[3].Value);

                furnitures.Add(furniture);
            }
        }

        Console.WriteLine("Bought furniture:");
        decimal totalSpend = 0m;
        foreach (Furniture furniture in furnitures)
        {
            Console.WriteLine(furniture.Name);
            totalSpend += furniture.Total;
        }
        
        Console.WriteLine($"Total money spend: {totalSpend:F2}");
    }
}
