using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Human1
    {
        public class Human
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string GroupName { get; set; }

            public virtual void ShowDetails()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Group: {GroupName}");
            }
        }
    }
}
