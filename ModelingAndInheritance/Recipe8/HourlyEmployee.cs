﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAndInheritance.Recipe8
{
    public class HourlyEmployee : Employee
    {
        public decimal? Rate { get; set; }
        public decimal? Hours { get; set; }
    }
}
