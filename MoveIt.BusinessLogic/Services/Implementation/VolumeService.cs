using MoveIt.BusinessLogic.Extensions;
using MoveIt.BusinessLogic.Volumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Services.Implementation
{
    public class VolumeService : IVolumeService
    {
        public double GetTotalVolume(double ordinaryVolume, double atticVolume)
        {
            var volumes = new List<VolumeBase>
            {
                new AtticVolume(atticVolume),
                new OrdinaryVolume(ordinaryVolume)
            };

            return volumes.Sum(x => x.GetRealVolume());
        }
    }
}
