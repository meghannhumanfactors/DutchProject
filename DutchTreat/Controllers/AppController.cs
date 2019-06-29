using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // this breaks my project.... [HttpPost("contact")]
        public IActionResult Contact()
        {
            if (ModelState.IsValid)
            {
                //Send the email
                //_mailService.SendMail("shawn@wildermuth.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
            }
            else
            {
                //Show the errors
            }


            ViewBag.Title = "Contact Us";

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
