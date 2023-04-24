using System;

/*
30
Students
Sunday

*/
internal class Program
{
    static void Main(string[] args)
    {
        int groupCount = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string weekDay = Console.ReadLine();
        double pricePerPerson = 0;
        double totalPrice = 0;
        
        switch (groupType)
        {
            case "Students":
                switch (weekDay)
                {
                    case "Friday":
                        pricePerPerson = 8.45;
                        break;
                    case "Saturday":
                        pricePerPerson = 9.80;
                        break;
                    case "Sunday":
                        pricePerPerson = 10.46;
                        break;
                }

                totalPrice = groupCount * pricePerPerson;

                if (groupCount >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 15 / 100);
                }

                break;
            case "Business":
                switch (weekDay)
                {
                    case "Friday":
                        pricePerPerson = 10.90;
                        break;
                    case "Saturday":
                        pricePerPerson = 15.60;
                        break;
                    case "Sunday":
                        pricePerPerson = 16;
                        break;
                }

                if (groupCount >= 100)
                {
                    groupCount -= 10;
                }

                totalPrice = groupCount * pricePerPerson;
                break;
            case "Regular":
                switch (weekDay)
                {
                    case "Friday":
                        pricePerPerson = 15;
                        break;
                    case "Saturday":
                        pricePerPerson = 20;
                        break;
                    case "Sunday":
                        pricePerPerson = 22.50;
                        break;
                }

                totalPrice = groupCount * pricePerPerson;

                if (groupCount >= 10 && groupCount <= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 5 / 100);
                }
                break;
        }

        Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}
