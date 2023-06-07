/*
Lewis 123456 20
Gosho 123456 99
Patricia 567343 54
End
*/

internal class Person
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }

    public Person(string name, string id, int age)
    {
        Id = id;
        Age = age;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name} with ID: {Id} is {Age} years old.";
    }
}

internal class Program
{
    static void Main()
    {
        List<Person> list = new List<Person>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();

            string name = arguments[0];
            string id = arguments[1];
            int age = int.Parse(arguments[2]);

            Person personFound = list.FirstOrDefault(person => person.Id == id);

            if (personFound != null)
            {
                personFound.Age = age;
                personFound.Name = name;
            }
            else
            {
                list.Add(new Person(name, id, age));
            }
        }

        List<Person> orderedPersons = list.OrderBy(person => person.Age).ToList();
        foreach (Person person in orderedPersons)
        {
            Console.WriteLine(person);
        }
    }
}
