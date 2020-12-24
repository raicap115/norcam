using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using norcam.Models;
using norcam.Data;
namespace norcam.Controllers
{
    public class ClienteController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var cliente = _context.Cliente.ToList();
            return View(cliente);
        }

         


        [HttpPost]
        public IActionResult Nuevo(Cliente objCliente)
        {
            if (ModelState.IsValid) {

                _context.Add(objCliente);
                _context.SaveChanges();
            }

            return View("Index");
        }
    }
}