using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.BusinessLogic.Services
{
    public interface IVolumeService
    {
        double GetTotalVolume(double ordinaryVolume, double atticVolume);
    }
}
