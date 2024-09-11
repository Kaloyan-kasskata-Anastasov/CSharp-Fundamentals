//int age = int.Parse(Console.ReadLine());

/*
Weekday
42

Holiday
-12
*/

// True && True = True
// True && False = False
// False && False = False

// True || True = True
// True || False = True
// False || False = False

// !True = False
// !False = True

string day = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
int price = 0;

switch (day)
{
    case "Weekday":
        if (age >= 0 && age <= 18)
        {
            price = 12;
        }
        else if (age >= 19 && age <= 64)
        {
            price = 18;
        }
        else if (age >= 65 && age <= 122)
        {
            price = 12;
        }

        break;
    case "Weekend":
        if (age >= 0 && age <= 18)
        {
            price = 15;
        }
        else if (age >= 19 && age <= 64)
        {
            price = 20;
        }
        else if (age >= 65 && age <= 122)
        {
            price = 15;
        }

        break;
    case "Holiday":
        if (age >= 0 && age <= 18)
        {
            price = 5;
        }
        else if (age >= 19 && age <= 64)
        {
            price = 12;
        }
        else if (age >= 65 && age <= 122)
        {
            price = 10;
        }

        break;
}

if (age < 0 || age > 122)
{
    Console.WriteLine("Error!");
}
else
{
    Console.WriteLine($"{price}$");
}
