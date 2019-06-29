using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;



namespace DutchTreat.Controllers
{
    public class AppController : Controller
         private readonly IMailService _mailService;

    public AppController(IMailService mailService)
    {
        _mailService = mailService;
    }



    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost("contact")]
    public IActionResult Contact(ContactViewModel model)
    {
        if (ModelState.IsValid)
        {
            //Send the email
            _mailService.SendMail("shawn@wildermuth.com", model.Subject, $"From: {model.UserName} - {model.UserEmail}, Message: {model.UserMessage}");
            ViewBag.UserMessage = "Mail Sent";
            ModelState.Clear();
        }
        //else
        //{
        //    //Show the errors
        //}


        ViewBag.Title = "Contact Us";

        return View();
    }

    internal class _mailService
    {
        internal static void SendMail(string v1, string subject, string v2)
        {
            throw new NotImplementedException();
        }
    }

    public IActionResult About()
    {
        ViewBag.Title = "About Us";

        return View();
    }
}
}
