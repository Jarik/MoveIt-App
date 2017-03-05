using MoveIt.BusinessLogic.Volumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Extensions
{
    public static class VolumeExtensions
    {
        public static double GetTotalVolume(this List<VolumeBase> volumes)
        {
            if (volumes == null)
            {
                return 0;
            }

            return volumes.Sum(x => x.GetRealVolume());
        }
    }
}
