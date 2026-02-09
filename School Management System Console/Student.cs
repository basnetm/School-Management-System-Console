using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System_Console
{
    public class Student : Person
    {
        public string Grade { get; set; }

        public void DisplayStudentInfo()
        {
            DisplayInfo(); 
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
