using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookDetails()
        {
            return View();
        }
    }
}
