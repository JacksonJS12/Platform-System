﻿namespace EnergySystem.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;

    using ViewModels;

    public class HomeController : BaseController
    {
        public IActionResult Index() => this.View();

        public IActionResult Privacy() => this.View();

        public IActionResult Reports() => this.View();
        public IActionResult Alerts() => this.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View(
        new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
    }
}
