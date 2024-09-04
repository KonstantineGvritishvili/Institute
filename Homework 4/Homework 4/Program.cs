using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_4.GroupManager1;
using static Homework_4.Lecturer1;
using static Homework_4.Student1;

namespace Homework_4
{
    internal class Program
    {
        class Program1
        {
            static void Main(string[] args)
            {
                GroupManager manager = new GroupManager
                {
                    Name = "Kote",
                    Age = 15,
                    GroupName = "Group A",
                    Company = "Mercedes"
                };

                Lecturer lecturer = new Lecturer
                {
                    Name = "Soso",
                    Age = 48,
                    GroupName = "Group N",
                    Company = "Nigga house"
                };

                Student student = new Student
                {
                    Name = "Nika",
                    Age = 20,
                    GroupName = "Group W",
                    Institute = "Sigma Boys"
                };

                manager.CreateGroup();
                manager.AddStudentToGroup();
                lecturer.Teach();
                lecturer.AssignHomeWork();
                student.Learn();
                student.DoHomeWork();

                Console.WriteLine("\nDetails:");
                manager.ShowDetails();
                lecturer.ShowDetails();
                student.ShowDetails();
            }
        }
    }
}
