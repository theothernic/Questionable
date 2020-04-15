using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [Route("{id}")]
        public IActionResult Show(Guid id)
        {
            return View();
        }
    }
}