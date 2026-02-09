using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System_Console
{
    public class Staff : Person
    {
        public string Department { get; set; }
        public string Position { get; set; }

        public void DisplayStaffInfo()
        {
            DisplayInfo(); 
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Position: {Position}");
        }
    }
}
