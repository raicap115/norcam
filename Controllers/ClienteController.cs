using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using norcam.Models;
using norcam.Data;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacto = await _context.Cliente.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,razon_social,ruc,direccion,telefono,fax")] Cliente cli)
        {
            if (id != cli.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cli);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cli);
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
                return RedirectToAction("Index");
            }

            return View(objCliente);
        }
    }
}