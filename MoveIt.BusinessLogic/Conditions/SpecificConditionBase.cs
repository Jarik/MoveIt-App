using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Conditions
{
    public abstract class SpecialCondions
    {
        public abstract int Multiplier { get; }

        public abstract double FixedPrice { get; }

        public double GetFullPrice(double price)
        {
            return price * Multiplier + FixedPrice;
        }
    }
}
