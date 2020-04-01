using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_TSES
{
    class Program
    {
        static void Main(string[] args)
        {
            var es = new ESContext();
            es.Computers.Add(new ESComputer() { Description = "ESComputer", CoolingType = "?", Price = 1500 });
            es.SaveChanges();


            var ts = new TSContext();
            ts.Computers.Add(new TSComputer()
            {
                Description = "ABC",
                CoolingType = "Hybrid",
                Price = 666,
                Server = new Server() { Bandwidth = 1300 }
            });
            ts.SaveChanges();


        }
    }
}
