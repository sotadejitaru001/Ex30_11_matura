using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_2023_template
{
    internal class Worker : Person
    {
        readonly int income;
        public Worker(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float we = 0, float l = 0, int income = 0) : base(bd, n, w, h, d, we, l)
        {
            this.income = income;
        }
    }
}
