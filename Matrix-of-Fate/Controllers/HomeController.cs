using Matrix_of_Fate.Models;
using Matrix_of_Fate.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Matrix_of_Fate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Matrix(Birthday birthday)
        {
            Calculate.SetDateOfBirth(birthday.Birth);
            return View(Calculate.GetMatrix());
        }

        public IActionResult Start()
        {
            return View();
        }
    }
}
