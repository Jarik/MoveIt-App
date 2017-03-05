using MoveIt.BusinessLogic.Extensions;
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
        // POST: api/Rate
        public IHttpActionResult Post([FromBody] MovementModel model)
        {
            var movementProcessor = model.Distance.CreateMovement();

            double rate = movementProcessor.GetRate(
                model.OrdinaryVolume, model.AtticVolume, model.Piano);

            return Ok(rate);
        }
    }
}
