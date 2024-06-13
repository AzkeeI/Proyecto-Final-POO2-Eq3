using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoFinalPOO2.Entities;
using ProyectoFinalPOO2.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoFinalPOO2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() => View();
        public IActionResult Privacy() => View();
        public IActionResult Contacto() => View();
        public IActionResult Servicios() => View();
        public IActionResult IniciarSesion() => View();
        public IActionResult MenuEnc() => View();

        [HttpPost]
        public IActionResult IniciarSesionPost(string correo, string contraseña)
        {
            if (EsValido(correo, contraseña))
            {
                return RedirectToAction("MenuEnc", "Encargado");
            }

            ViewBag.Error = "Credenciales inválidas. Por favor, intenta de nuevo.";
            return View("IniciarSesion");
        }

        private bool EsValido(string correoEnc, string contraseñaEnc)
        {
            var encargado = _context.LoginEncargados
                .FirstOrDefault(e => e.CorreoEnc == correoEnc && e.ContraseñaEnc == contraseñaEnc);

            return encargado != null;
        }

        [HttpGet]
        public IActionResult CrearCuenta() => View();

        [HttpPost]
        public IActionResult CrearCuenta(LoginEncargadoModel model)
        {
            if (ModelState.IsValid)
            {
                var reg = new LoginEncargado
                {
                    Id = Guid.NewGuid(),
                    CorreoEnc = model.CorreoEnc,
                    ContraseñaEnc = model.ContraseñaEnc,
                };

                _context.LoginEncargados.Add(reg);
                _context.SaveChanges();

                return RedirectToAction("CrearCuenta", "Home");
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
