/*
USA

Germany

*/

class Program
{
    static void Main()
    {
        string country = Console.ReadLine();

        if (country == "England" || country == "USA")
        {
            Console.WriteLine("English");
        }
        else if (country == "Spain" || country == "Argentina" || country == "Mexico")
        {
            Console.WriteLine("Spanish");
        }
        else
        {
            Console.WriteLine("unknown");
        }

        //switch (country)
        //{
        //    case "England":
        //    case "USA":
        //        Console.WriteLine("English");
        //        break;
        //    case "Spain":
        //    case "Argentina":
        //    case "Mexico":
        //        Console.WriteLine("Spanish");
        //        break;
        //    default:
        //        Console.WriteLine("unknown");
        //        break;
        //}
    }
}
