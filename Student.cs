using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_2023_template
{
    internal class Student:Person
    {
        public Student(DateTime bd, string n, float w = 0, float h = 0, float d = 0) 
            : base(bd, n, w, h, d)
        {
        }
    }
}
