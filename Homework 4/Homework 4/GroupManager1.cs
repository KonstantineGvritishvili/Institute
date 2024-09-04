using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_4.Human1;
using System.Xml.Linq;

namespace Homework_4
{
    internal class GroupManager1
    {
        public class GroupManager : Human
        {
            public string Company { get; set; }

            public void CreateGroup()
            {
                Console.WriteLine($"Group created by manager {Name}");
            }

            public void AddStudentToGroup()
            {
                Console.WriteLine($"Student added to group by manager {Name}");
            }

            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine($"Company: {Company}");
            }
        }
    }
}
