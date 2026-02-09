using School_Management_System_Console;
using System.Security.Cryptography.X509Certificates;

//Student student = new Student();
//student.Name = "Manoj";
//student.Id = 1;
//student.Age = 7;
//student.Grade = "7A";


//student.DisplayStudentInfo();



//Teacher teacher = new Teacher();
//teacher.Name = "Ravi";
//teacher.Id = 2;
//teacher.Age = 35;
//teacher.Subject = "Math";
//teacher.Salary = 45000; 

//teacher.DisplayTeacherInfo();


//Console.WriteLine("------------------");

//Staff staff = new Staff();
//staff.Name = "Suresh";
//staff.Id = 3;
//staff.Age = 40;
//staff.Department = "Administration";
//staff.Position = "Clerk";

//staff.DisplayStaffInfo();

bool status = true;
List<Student> students = new List<Student>();
List<Teacher> teachers = new List<Teacher>();



while (status)
{
    Console.WriteLine("\n--- School Management System ---");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Teacher");
    Console.WriteLine("3. Add Staff");
    Console.WriteLine("4. search");
    Console.WriteLine("5. SearchBYName");
    Console.WriteLine("6. Exit");


    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {

        Student student = new Student();

        Console.WriteLine("Enter Name:");
        student.Name = Console.ReadLine();

        Console.WriteLine("Enter ID:");
        student.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Age:");
        student.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Grade:");
        student.Grade = Console.ReadLine();

        students.Add(student);   

        student.DisplayStudentInfo();
    }
    else if (choice == 2)
    {
        Teacher teacher = new Teacher();

        Console.WriteLine("Enter Name:");
        teacher.Name = Console.ReadLine();

        Console.WriteLine("Enter ID:");
        teacher.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Age:");
        teacher.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Subject:");
        teacher.Subject = Console.ReadLine();

        Console.WriteLine("Enter salery:");
        teacher.Salary = decimal.Parse(Console.ReadLine());

        teachers.Add(teacher);


        teacher.DisplayTeacherInfo();
    }
    else if (choice == 3)
    {
        Staff staff = new Staff();

        Console.WriteLine("Enter Name:");
        staff.Name = Console.ReadLine();

        Console.WriteLine("Enter ID:");
        staff.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Age:");
        staff.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Department:");
        staff.Department = Console.ReadLine();

        Console.WriteLine("Enter position:");
        staff.Position = Console.ReadLine();


        staff.DisplayStaffInfo();
    }
    else if (choice == 4)
    {
        Console.WriteLine("Enter ID to search:");
        int searchId = int.Parse(Console.ReadLine());

        Student found = students.FirstOrDefault(s => s.Id == searchId);

        if (found != null)
        {
            Console.WriteLine("Student Found:");
            found.DisplayStudentInfo();
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    else if (choice == 5)
    {
        Console.WriteLine("Enter Name of TeacherName to search:...");
        var foundName= Console.ReadLine();
      
        Teacher found=teachers.FirstOrDefault(s => s.Name == foundName);
        if (found != null)
        {
            Console.WriteLine("Teacher Found:");
            found.DisplayTeacherInfo();
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
        break;
    }

    else if (choice == 6)
    {
        Console.WriteLine("Exiting...");
        break;  
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }
}
