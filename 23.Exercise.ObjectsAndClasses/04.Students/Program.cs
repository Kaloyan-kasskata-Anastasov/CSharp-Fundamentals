internal class Program
{
    class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }

    static void Main()
    {
        List<Student> students = new List<Student>();
        int studentsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentsCount; i++)
        {
            string[] studentString = Console.ReadLine().Split();
            Student student = new Student(studentString[0],
                studentString[1],
                float.Parse(studentString[2]));

            students.Add(student);
        }

        students = students.OrderByDescending(x => x.Grade).ToList();

        Console.WriteLine(string.Join("\n", students));
    }
}
