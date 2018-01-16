using CORE.Model;
using CORE.Services.ParkingServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RestApi.Controllers.ParkingServices
{
    [RoutePrefix("api")]
    public class ParkingServicesController : ApiController
    {
        [HttpGet]
        [Route("ParkingServices/all")]
        public object GetAllParkingServiceController()
        {
            return Ok(ParkingServicesService.GetAllParkingService());
        }

        [HttpGet]
        [Route("ParkingServices/all/vehicularPlate/{vehicularPlate}")]
        public object GetAllParkingServiceByVehicularPlateController(string vehicularPlate)
        {
            return Ok(ParkingServicesService.GetAllParkingServiceByVehicularPlate(vehicularPlate));
        }

        [HttpGet]
        [Route("ParkingServices/last/vehicularPlate/{vehicularPlate}")]
        public object GetLastParkingServiceByVehicleController(string vehicularPlate)
        {
            return Ok(ParkingServicesService.GetLastParkingServiceByVehicularPlate(vehicularPlate));
        }

        [HttpGet]
        [Route("ParkingServices/previous/vehicularPlate/{vehicularPlate}")]
        public object GetPreviousParkingServiceByVehicularPlateController(string vehicularPlate)
        {
            return Ok(ParkingServicesService.GetPreviousParkingServiceByVehicularPlate(vehicularPlate));
        }

        [HttpGet]
        [Route("ParkingServices/cuerrentServices/vehicules")]
        public object GetAllTheCurrentServicesAndTheirVehicles()
        {
            return Ok(ParkingServicesService.GetAllTheCurrentServicesAndTheirVehicles());
        }

        [HttpPost]
        [Route("ParkingServices/new")]
        public IHttpActionResult PostParkingServiceController(ParkingService parkingService)
        {
            ParkingServicesService.PostParkingService(parkingService);
            return Ok();
        }

        [HttpPut]
        [Route("ParkingServices/update")]
        public IHttpActionResult PutParkingServiceController([FromBody]ParkingService parkingService)
        {
            ParkingServicesService.PutParkingService(parkingService);
            return Ok();
        }

        [HttpDelete]
        [Route("ParkingServices/id/{id:int}")]
        public IHttpActionResult DeleteParkingServiceController(int id)
        {
            ParkingServicesService.DeleteParkingService(id);
            return Ok();
        }
    }
}