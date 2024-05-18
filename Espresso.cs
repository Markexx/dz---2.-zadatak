using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_2._zadatak
{
    public class Espresso : ICoffee
    {
        public double GetCost()
        {
            return 1.99;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
