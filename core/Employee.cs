﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1.core
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee() { }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
