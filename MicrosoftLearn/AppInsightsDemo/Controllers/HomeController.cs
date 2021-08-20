﻿using AppInsightsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;

namespace AppInsightsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TelemetryClient aiClient;

        //public HomeController(TelemetryClient aiClient)
        //{
        //    this.aiClient = aiClient;
        //}

        public HomeController(ILogger<HomeController> logger, TelemetryClient aiClient)
        {
            _logger = logger;
            this.aiClient = aiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
        public ActionResult Like(string button)
        {
            this.aiClient.TrackEvent("LikeClicked");
            ViewBag.Message = "Thank you for your response";
            return View("Index");
        }
    }
}
