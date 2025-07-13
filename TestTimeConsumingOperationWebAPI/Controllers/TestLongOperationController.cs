using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestTimeConsumingOperationWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestLongOperationController : ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            await Task.Delay(5000);
            return Content("web API Long Operaiton completed");
        }
    }
}
