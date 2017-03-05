using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Rates
{
    public class SmallRate : RateBase
    {
        private const double KmPrice = 10;
        private const double InitialPrice = 1000;

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

        public SmallRate(double distance, double volume) : base(distance, volume) { }
    }
}
