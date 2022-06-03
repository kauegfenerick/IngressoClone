using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
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
        [HttpPost]
        public IActionResult CinemaCriar(PostCinemaDTO cinemaDto)
        {
            if (!ModelState.IsValid)
            {
                return View(cinemaDto);
            }
            Cinema cinema = new Cinema(cinemaDto.Nome,cinemaDto.Descricacao,cinemaDto.LogoURL);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return RedirectToAction(nameof(CinemaListar));
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
