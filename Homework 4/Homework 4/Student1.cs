using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_4.Human1;
using System.Xml.Linq;

namespace Homework_4
{
    internal class Student1
    {
        public class Student : Human
        {
            public string Institute { get; set; }

            public void Learn()
            {
                Console.WriteLine($"{Name} is learning.");
            }

            public void DoHomeWork()
            {
                Console.WriteLine($"{Name} is doing homework.");
            }

            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine($"Institute: {Institute}");
            }
        }

    }
}
