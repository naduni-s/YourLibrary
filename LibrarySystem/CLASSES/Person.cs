﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.CLASSES
{
    internal class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
