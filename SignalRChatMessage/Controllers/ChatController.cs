using Microsoft.AspNetCore.Mvc;

namespace SignalRChatMessage.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
