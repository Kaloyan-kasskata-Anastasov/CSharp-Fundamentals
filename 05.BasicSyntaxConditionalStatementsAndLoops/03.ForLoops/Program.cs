internal class Program
{
    static void Main()
    {
        int i = 0;
        for (; i < 100; i+= 3)
        {
            Console.WriteLine(i);
        }

        i = 0;
        while (i < 100)
        {
            Console.WriteLine(i);
            i++;
        }
        
        do
        {
            if (i > 0)
            {
                i = 0;
            }

            Console.WriteLine(i);
            i++;
        } while (i < 100);
    }
}
