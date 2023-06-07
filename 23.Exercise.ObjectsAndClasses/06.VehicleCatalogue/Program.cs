/*
End
Close the Catalogue

*/

enum Type
{
    Car,
    Truck
}

class Vehicle
{
    public Type Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal HP { get; set; }

    public Vehicle(string type, string model, string color, string hp)
    {
        Type = type == "car" ? Type.Car : Type.Truck;
        Model = model;
        Color = color;
        HP = decimal.Parse(hp);
    }

    public override string ToString()
    {
        return $"Type: {Type}\n" +
               $"Model: {Model}\n" +
               $"Color: {Color}\n" +
               $"Horsepower: {HP}";
    }
}

internal class Program
{
    static void Main()
    {
        List<Vehicle> catalogue = new List<Vehicle>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();

            string type = arguments[0];
            string model = arguments[1];
            string color = arguments[2];
            string hp = arguments[3];

            catalogue.Add(new Vehicle(type, model, color, hp));
        }

        while ((command = Console.ReadLine()) != "Close the Catalogue")
        {
            string vehicleModel = command;

            Vehicle found = catalogue.FirstOrDefault(v => v.Model == vehicleModel);
            if (found != null)
            {
                Console.WriteLine(found);
            }
        }

        decimal averageHP = catalogue
            .Where(vehicle => vehicle.Type == Type.Car)
            .Select(vehicle => vehicle.HP)
            .DefaultIfEmpty()
            .Average();
        Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

        averageHP = catalogue
            .Where(vehicle => vehicle.Type == Type.Truck)
            .Select(vehicle => vehicle.HP)
            .DefaultIfEmpty()
            .Average();
        Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
    }
}
