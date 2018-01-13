using CORE.Services.Vehicle;
using CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RestApi.Controllers.Vehicle
{
    [RoutePrefix("api")]
    public class VehicleController : ApiController
    {
        [HttpGet]
        [Route("Vehicle/plate/{plate}")]
        public object GetVehiclesByplateController(string plate) {
            return Ok(VehicleService.GetVehiclesByPlate(plate));
        }

        [HttpPost]
        [Route("Vehicle/new")]
        public IHttpActionResult PostVehicleController(CORE.Model.Vehicle vehicle)
        {
            VehicleService.PostVehicle(vehicle);
            return Ok();
        }

        [HttpPut]
        [Route("Vehicle/update")]
        public IHttpActionResult PutVehicleController([FromBody]CORE.Model.Vehicle vehicle)
        {
            VehicleService.PutVehicle(vehicle);
            return Ok();
        }

        [HttpDelete]
        [Route("Vehicle/id/{id:int}")]
        public IHttpActionResult DeleteVehicleController(int id)
        {
            VehicleService.DeleteVehicle(id);
            return Ok();
        }
    }
}