using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_2._zadatak
{
    public class Sugar : CoffeeDecorator
    {
        public Sugar(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return base.GetCost() + 0.20;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }
    }
}
