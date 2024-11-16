namespace PersonHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", 20);
            Console.WriteLine("Student:");
            student.ShowStudentInfo();
            student.GoToClasses();

            Console.WriteLine();

            Teacher teacher = new Teacher("Mr. Smith", 45, "Mathematics");
            Console.WriteLine("Teacher:");
            teacher.ShowTeacherInfo();
            teacher.Explain();
        }
    }
}


