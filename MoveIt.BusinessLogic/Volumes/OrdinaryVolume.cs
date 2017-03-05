using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Volumes
{
    public class OrdinaryVolume : VolumeBase
    {
        protected override int Multiplier
        {
            get { return 1; }
        }

        public OrdinaryVolume(double volume) : base(volume) { }
    }
}
