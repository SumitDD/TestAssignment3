using Microsoft.AspNetCore.Mvc;

namespace Test_Assignment_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {
            
        }

        [HttpGet]
        public void Get()
        {
        }
    }
}