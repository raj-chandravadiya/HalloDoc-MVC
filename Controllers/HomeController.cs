using HalloDoc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HalloDoc.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login_page()
        {
            return View();
        }
        public IActionResult forgot_password()
        {
            return View();
        }
        public IActionResult patient_site()
        {
            return View();
        }
        public IActionResult submit_request_screen()
        {
            return View();
        }
        public IActionResult create_patient_request()
        {
            return View();
        }
        public IActionResult create_familyfriend_request()
        {
            return View();
        }
        public IActionResult create_concierge_request()
        {
            return View();
        }
        public IActionResult create_businesspartner_request()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
       
    }
}