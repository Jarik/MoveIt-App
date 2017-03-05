
namespace MoveIt.BusinessLogic.Volumes
{
    public abstract class VolumeBase
    {
        protected virtual int Multiplier { get; }

        protected double OriginalVolume = 0;

        public VolumeBase(double volume)
        {
            this.OriginalVolume = volume;
        }

        public double GetRealVolume()
        {
            return this.Multiplier * this.OriginalVolume;
        }
    }
}
