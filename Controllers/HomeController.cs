﻿using HalloDoc.Models;
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


        public IActionResult Privacy()
        {
            return View();
        }
       
    }
}