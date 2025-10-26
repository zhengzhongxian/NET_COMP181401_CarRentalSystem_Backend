using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("GetAllFuelMessages")]
        public IActionResult GetAllFuelMessages()
        {
            var allConstants = ReflectionHelper.GetAllConstants(typeof(FuelMessage));
            return Ok(allConstants);
        }
    }
}
