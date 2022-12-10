using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using SistemaDeLogin_MVC_ComEF.Models;
using System;
using System.Diagnostics;

namespace SistemaDeLogin_MVC_ComEF.Controllers
{
    [Authorize]//Adiciona "Autorização necessaria" para visualizar as Views
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
                return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]//habilita vizualizar sem logar
        public IActionResult Contact()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}