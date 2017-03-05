using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveIt.BusinessLogic.Rates;

namespace MoveIt.BusinessLogic.Movement.Implementation
{
    public class SmallMovementProcessor : MovementProcessorBase
    {
        public SmallMovementProcessor(double distance) : base(distance) { }

        public override RateBase CreateRate(double distance, double volume, bool piano)
        {
            return new SmallRate(distance, volume);
        }
    }
}
