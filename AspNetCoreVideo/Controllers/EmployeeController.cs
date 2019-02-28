using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        public ContentResult Name()
        {
            return Content("Charles");
        }

        public string Country()
        {
            return "USA";
        }
        public string Index()
        {
            return "Hello from Employee Controller!";
        }
    }
}
