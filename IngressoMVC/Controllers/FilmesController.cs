using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class FilmesController : Controller
    {
        private IngressoDbContext _context;
        public FilmesController(IngressoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult FilmeListar()
        {
            return View(_context.Filmes);
        }
        public IActionResult FilmeDetalhes(int id)
        {
            return View(_context.Filmes.Find(id));
        }
        public IActionResult FilmeCriar()
        {
            return View();
        }
        public IActionResult FilmeAtualizar(int id)
        {
            return View();
        }
        public IActionResult FilmeDeletar(int id)
        {
            return View();
        }
    }
}
