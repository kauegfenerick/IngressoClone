using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class CategoriasController : Controller
    {
        private IngressoDbContext _context;
        public CategoriasController(IngressoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CategoriaListar()
        {
            return View(_context.Categorias);
        }
        public IActionResult CategoriaDetalhes(int id)
        {
            return View(_context.Categorias.Find(id));
        }
        public IActionResult CategoriaCriar()
        {
            return View();
        }
        public IActionResult CategoriaAtualizar(int id)
        {
            return View();
        }
        public IActionResult CategoriaDeletar(int id)
        {
            return View();
        }
    }
}
