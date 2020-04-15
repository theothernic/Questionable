using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [Route("{id}")]
        public IActionResult Show()
        {
            return View();
        }
    }
}