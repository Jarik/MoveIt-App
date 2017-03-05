using System;

namespace MoveIt.BusinessLogic.Rates
{
    public abstract class RateBase
    {
        const int DefaultVolumePerCar = 50;

        public abstract double StartPrice { get; }
        public abstract double KilometerPrice { get; }

        public double Distance { get; }
        public double Volume { get; }

        public RateBase (double distance, double volume)
        {
            this.Distance = distance;
            this.Volume = volume;
        }

        protected double GetCarsCount(double volume)
        {
            return Math.Round(volume / DefaultVolumePerCar);
        }

        public double GetPrice()
        {
            return (this.StartPrice + Distance * KilometerPrice) * this.GetCarsCount(Volume);
        }
    }
}
