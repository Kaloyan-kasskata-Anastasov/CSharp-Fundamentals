internal class Program
{
    static void Main()
    {
        Dictionary<string, uint> resourcesMap = new Dictionary<string, uint>();

        string resource;
        uint quantity;
        while ((resource = Console.ReadLine()) != "stop")
        {
            if (!resourcesMap.ContainsKey(resource))
            {
                resourcesMap.Add(resource, 0);
            }

            quantity = uint.Parse(Console.ReadLine());
            resourcesMap[resource] += quantity;
        }

        foreach (KeyValuePair<string, uint> pair in resourcesMap)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
