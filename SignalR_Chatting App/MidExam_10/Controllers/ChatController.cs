using Microsoft.AspNetCore.Mvc;

namespace MidExam_10.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
