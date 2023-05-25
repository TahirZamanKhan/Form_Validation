using Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(FormModel form)
        {
            return View(form);
        }
    }
}
