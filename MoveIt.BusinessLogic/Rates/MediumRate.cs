using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Rates
{
    public class MediumRate : RateBase
    {
        private const double KmPrice = 8;
        private const double InitialPrice = 5000;

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

        public MediumRate(double distance, double volume) : base(distance, volume) { }
    }
}
