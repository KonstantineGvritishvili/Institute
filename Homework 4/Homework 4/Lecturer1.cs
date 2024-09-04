using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_4.Human1;
using System.Xml.Linq;

namespace Homework_4
{
    internal class Lecturer1
    {
        public class Lecturer : Human
        {
            public string Company { get; set; }

            public void Teach()
            {
                Console.WriteLine($"{Name} is teaching.");
            }

            public void AssignHomeWork()
            {
                Console.WriteLine($"Homework assigned by {Name}");
            }

            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine($"Company: {Company}");
            }
        }
    }
}
