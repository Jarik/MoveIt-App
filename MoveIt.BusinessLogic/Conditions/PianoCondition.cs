using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Conditions
{
    public class PianoCondition : SpecialCondions
    {
        private const int PianoMultiplier = 1;
        private const double PianoMovementCost = 5000;

        public override double FixedPrice
        {
            get
            {
                return PianoMovementCost;
            }
        }

        public override int Multiplier
        {
            get
            {
                return PianoMultiplier;
            }
        }
    }
}
