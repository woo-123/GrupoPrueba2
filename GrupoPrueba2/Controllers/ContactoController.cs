using Microsoft.AspNetCore.Mvc;
using GrupoPrueba2.Models;
using GrupoPrueba2.Data;
using System.Linq;

namespace GrupoPrueba2.Controllers
{

    public class ContactoController:Controller
    {


        private readonly ApplicationDbContext _context;
        public ContactoController(ApplicationDbContext context){
            _context=context;
        }
        public IActionResult Index(){
            
            
            return View(_context.DataContactos.ToList());

        }
        
        public IActionResult Create(){
            
            return View();

        }

        [HttpPost]

        public IActionResult Create(Contact objContacto){
            
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto ya esta registrado";
            return RedirectToAction("Index");

        }
    }

}