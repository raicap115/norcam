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
        public IActionResult Anular(int id){
            var cliente = _context.Cliente.FirstOrDefault(x => x.id == id);
            _context.Remove(cliente);            
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Cliente cl){
            Cliente cliente = _context.Cliente.Where(x => x.id == cl.id).FirstOrDefault();
            _context.Remove(cliente);
            _context.SaveChanges();
            cliente.razon_social = cl.razon_social;
            cliente.ruc = cl.ruc;
            cliente.direccion = cl.direccion;
            cliente.telefono = cl.telefono;
            cliente.fax = cl.fax;
            _context.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar(int id){
            var cliente = _context.Cliente.Find(id);
            return new JsonResult(cliente);
        }

    public IActionResult Nuevo()
    {
        return View();
    }

        [HttpPost]
        public IActionResult Nuevo(Cliente objCliente)
        {
            if (ModelState.IsValid) {

                _context.Add(objCliente);
                _context.SaveChanges();
            }

            return View("Index","Cliente");
        }
    }
}