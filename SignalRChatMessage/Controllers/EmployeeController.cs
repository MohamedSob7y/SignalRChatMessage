using Microsoft.AspNetCore.Mvc;

namespace SignalRChatMessage.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
