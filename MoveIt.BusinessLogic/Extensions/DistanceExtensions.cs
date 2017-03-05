using MoveIt.BusinessLogic.Movement;
using MoveIt.BusinessLogic.Movement.Implementation;


namespace MoveIt.BusinessLogic.Extensions
{
    public static class DistanceExtensions
    {        
        public static MovementProcessorBase CreateMovement(this double distance)
        {
            const int smallMovementDistance = 50;
            const int largeMovementDistance = 100;

            if (distance < smallMovementDistance)
            {
                return new SmallMovementProcessor(distance);
            }
            else if (distance >= largeMovementDistance)
            {
                return new LargeMovementProcessor(distance);
            }
            else
            {
                return new MediumMovementProcessor(distance);
            }
        }
    }
}
