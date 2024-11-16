using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowStudentInfo()
        {
            Greet();
            ShowAge();
        }
    }
}
