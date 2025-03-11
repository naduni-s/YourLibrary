using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibrarySystem.CLASSES
{
    internal class Librarian : Person
    {
        public int EmployeeID { get; set; }
        public Librarian(string name, int employeeID) : base(name)
        {
            EmployeeID = employeeID;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Employee ID: {EmployeeID}");
        }
    }
}
