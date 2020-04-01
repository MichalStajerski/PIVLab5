﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_TSES
{
    public class TSComputer
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CoolingType { get; set; }
        public virtual Server Server { get; set; }

    }
}
