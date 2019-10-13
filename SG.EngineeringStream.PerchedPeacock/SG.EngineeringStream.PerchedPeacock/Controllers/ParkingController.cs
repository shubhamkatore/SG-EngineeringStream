using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SG.EngineeringStream.PerchedPeacock.Service.Interfaces;

namespace SG.EngineeringStream.PerchedPeacock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private IParkingService _parkingService;

        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }
        // GET: api/Parking
        [HttpGet]
        public OkObjectResult Get()
        {
            return Ok(_parkingService.GetParkings(Startup.ConnectionString));
        }


        // POST: api/Parking
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Parking/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
