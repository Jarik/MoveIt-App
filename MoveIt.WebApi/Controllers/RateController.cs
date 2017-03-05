using MoveIt.BusinessLogic.Extensions;
using MoveIt.BusinessLogic.Services;
using MoveIt.BusinessLogic.Services.Implementation;
using MoveIt.Models;
using MoveIt.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoveIt.WebApi.Controllers
{
    public class RateController : ApiController
    {
        public IVolumeService VolumeService = new VolumeService();

        // POST: api/Rate
        public IHttpActionResult Post([FromBody] MovementModel model)
        {
            var movementProcessor = model.Distance.CreateMovement();

            var volume = VolumeService.GetTotalVolume(model.OrdinaryVolume, model.AtticVolume);

            double rate = movementProcessor.GetRate(
                volume, model.Piano);

            return Ok(rate);
        }
    }
}
