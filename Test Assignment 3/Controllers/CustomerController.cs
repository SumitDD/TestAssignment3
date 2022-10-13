using Microsoft.AspNetCore.Mvc;

namespace Test_Assignment_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {

        }

        [HttpGet]
        public void Get()
        {
        }
    }
}