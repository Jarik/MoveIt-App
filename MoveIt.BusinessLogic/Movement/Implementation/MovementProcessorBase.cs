using MoveIt.BusinessLogic.Conditions;
using MoveIt.BusinessLogic.Rates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Movement.Implementation
{
    public abstract class MovementProcessorBase : IMovementProcessor
    {
        protected double Distance = 0;

        public MovementProcessorBase(double distance)
        {
            this.Distance = distance;
        }

        public abstract RateBase CreateRate(double distance, double volume, bool piano);

        public double GetRate(double volume, bool piano)
        {
            var rate = this.CreateRate(this.Distance, volume, piano);

            var price = rate.GetPrice();

            if (piano)
            {
                var pianoCondition = new PianoCondition();

                price = pianoCondition.GetFullPrice(price);
            }

            return price;
        }
    }
}
