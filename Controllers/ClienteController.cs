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

<<<<<<< HEAD
         
=======
        [HttpGet]
        public IActionResult Create()
        {
            Cliente cli= new Cliente();
            return PartialView("_NuevoClientePartial",cli);
        }
>>>>>>> 2c35d5362133eeae16e8a365838d9802a2906016

        [HttpPost]
        public IActionResult Anular(int id){
            var cliente = _context.Cliente.FirstOrDefault(x => x.id == id);
            _context.Remove(cliente);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar(int id){
            var cliente = _context.Cliente.Find(id);
            return new JsonResult(cliente);
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