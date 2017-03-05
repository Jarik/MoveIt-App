using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Volumes
{
    public class AtticVolume : VolumeBase
    {
        protected override int Multiplier
        {
            get { return 2; }
        }

        public AtticVolume(double volume) : base(volume) { }
    }
}
