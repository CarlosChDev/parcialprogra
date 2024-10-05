using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using parcialprogra.Data;
using parcialprogra.Models;

namespace parcialprogra.Controllers
{
    public class TransaccionController : Controller
    {
        private readonly ILogger<TransaccionController> _logger;
        private readonly ApplicationDbContext _context;

        public TransaccionController(ILogger<TransaccionController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Abrir(Transaccion modelo)
        {
            _context.Add(modelo);
            _context.SaveChanges();
            ViewData["Message"] = "Se hizo la transaccion";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}