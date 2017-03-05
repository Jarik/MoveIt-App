using MoveIt.BusinessLogic.Rates;

namespace MoveIt.BusinessLogic.Movement
{
    public interface IMovementProcessor
    {
        RateBase CreateRate(double distance, double volume, bool piano);
    }
}
