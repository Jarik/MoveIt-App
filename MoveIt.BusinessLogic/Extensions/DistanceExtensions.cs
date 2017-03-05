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

            // IT IT A POINT FOR LAMBDA OR Something like SMart enum. Time limitation and I left if...
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
