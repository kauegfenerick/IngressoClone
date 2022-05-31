using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class AtoresController : Controller
    {
        private IngressoDbContext _context;
        public AtoresController(IngressoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AtorListar() 
        {
            return View(_context.Atores);
        }
        public IActionResult AtorDetalhes(int id)
        {
            return View(_context.Atores.Find(id));
        }
        public IActionResult AtorCriar()
        {
            return View();
        }
        public IActionResult AtorAtualizar(int id)
        {
            return View();
        }
        public IActionResult AtorDeletar(int id)
        {
            return View();
        }
    }
}
