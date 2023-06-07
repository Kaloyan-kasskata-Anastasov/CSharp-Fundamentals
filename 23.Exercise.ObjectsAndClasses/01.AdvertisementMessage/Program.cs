internal class Program
{
    class Advertisement
    {
        private readonly string[] phrases =
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
        };

        private readonly string[] events =
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        private readonly string[] authors =
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        private readonly string[] cities =
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        public string GetRandomMessage()
        {
            Random random = new Random();
            
            int index = random.Next(phrases.Length);
            string phrase = phrases[index];
            
            index = random.Next(events.Length);
            string @event = events[index];

            index = random.Next(authors.Length);
            string author = authors[index];

            index = random.Next(cities.Length);
            string city = cities[index];

            return $"{phrase} {@event} {author} – {city}.";
        }
    }

    static void Main()
    {
        int messagesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < messagesCount; i++)
        {
            Advertisement ad = new Advertisement();
            Console.WriteLine(ad.GetRandomMessage());
        }
    }
}
