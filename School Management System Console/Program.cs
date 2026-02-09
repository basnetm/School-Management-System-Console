using School_Management_System_Console;

Student student = new Student();
student.Name = "Manoj";
student.Id = 1;
student.Age = 7;
student.Grade = "7A";


student.DisplayStudentInfo();



Teacher teacher = new Teacher();
teacher.Name = "Ravi";
teacher.Id = 2;
teacher.Age = 35;
teacher.Subject = "Math";
teacher.Salary = 45000;

teacher.DisplayTeacherInfo();


Console.WriteLine("------------------");

Staff staff = new Staff();
staff.Name = "Suresh";
staff.Id = 3;
staff.Age = 40;
staff.Department = "Administration";
staff.Position = "Clerk";

staff.DisplayStaffInfo();