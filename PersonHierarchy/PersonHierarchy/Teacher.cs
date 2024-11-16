using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    public class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }
        public void Explain()
        {
            Console.WriteLine($"Explanation beings for {subject}.");
        }
        public void ShowTeacherInfo()
        {
            Greet();
            ShowAge();
        }
    }
}
