using MoveIt.SelfHosted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MoveIt.SelfHosted.Controllers
{
    public class RateController : ApiController
    {
        [HttpGet]
        public int Get(int distance)
        {
            return 5;
        }
    }
}
