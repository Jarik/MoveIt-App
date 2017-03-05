using MoveIt.BusinessLogic.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic
{
    public class MovementDetails
    {
        public IMovementProcessor movement { get; private set; }

        public MovementDetails(double distance,
            double volume,
            bool piano)
        {

        }
    }
}
