using CORE.Services.Rates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RestApi.Controllers.Rates
{
    [RoutePrefix("api")]
    public class RatesController : ApiController
    {
        [HttpGet]
        [Route("Rates/all")]
        public object GetAllRatesController()
        {
            return Ok(RatesService.GetAllRates());
        }

        [HttpPost]
        [Route("Rates/new")]
        public IHttpActionResult PostRatesController(CORE.Model.Rates rate)
        {
            RatesService.PostRates(rate);
            return Ok();
        }

        [HttpPut]
        [Route("Rates/update")]
        public IHttpActionResult PutRatesController([FromBody]CORE.Model.Rates rate)
        {
            RatesService.PutRates(rate);
            return Ok();
        }

        [HttpDelete]
        [Route("Rates/id/{id:int}")]
        public IHttpActionResult DeleteRateController(int id)
        {
            RatesService.DeleteRate(id);
            return Ok();
        }
    }
}