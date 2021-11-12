using Microsoft.AspNetCore.Mvc;
using GrupoPrueba2.Models;
using GrupoPrueba2.Data;
using System.Linq;

namespace frutosecoapp.Controllers
{
    public class ContactController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.DataContactos.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact objContact)
        {
            _context.Add(objContact);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto ya esta registrado"; 
            return View();
        }

        public IActionResult Edit(int id)
        {
            Contact objContact=_context.DataContactos.Find(id);
            if(objContact==null){
                return NotFound();
            }

            return View(objContact);
        }

        [HttpPost]

        public IActionResult Edit(int id,[Bind("Id,Email,Name,Phone,Comment")] Contact objContact)
        {
            _context.Update(objContact);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto ha sido actualizado";
            return View(objContact);
        }

        public IActionResult Delete(int id)
        {
            Contact objContact=_context.DataContactos.Find(id);
            _context.DataContactos.Remove(objContact);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    
    }


}