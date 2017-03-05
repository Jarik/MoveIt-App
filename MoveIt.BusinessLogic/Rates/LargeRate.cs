using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Rates
{
    public class LargeRate : RateBase
    {
        private const double KmPrice = 7;
        private const double InitialPrice = 10000;

        public override double KilometerPrice
        {
            get
            {
                return KmPrice;
            }
        }

        public override double StartPrice
        {
            get
            {
                return InitialPrice;
            }
        }

        public LargeRate(double distance, double volume) : base(distance, volume) { }
    }
}
