using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System_Console
{
    public  class Teacher: Person
    {
        public string Subject { get; set; }
        public decimal Salary { get; set; }

        public void DisplayTeacherInfo()
        {
            DisplayInfo(); 
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Salary: {Salary}");
        }

    }
}
