using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class CinemasController : Controller
    {
        private IngressoDbContext _context;
        public CinemasController(IngressoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CinemaListar()
        {
            return View(_context.Cinemas);
        }
        public IActionResult CinemaDetalhes(int id)
        {
            return View(_context.Cinemas.Find(id));
        }
        public IActionResult CinemaCriar()
        {
            return View();
        }
        public IActionResult CinemaAtualizar(int id)
        {
            return View();
        }
        public IActionResult CinemaDeletar(int id)
        {
            return View();
        }
    }
}
