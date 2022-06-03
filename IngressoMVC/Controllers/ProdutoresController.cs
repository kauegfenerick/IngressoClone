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
    public class ProdutoresController : Controller
    {
        private IngressoDbContext _context;
        public ProdutoresController(IngressoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ProdutorListar()
        {
            return View(_context.Produtores);
        }
        public IActionResult ProdutorDetalhes(int id)
        {
            return View(_context.Produtores.Find(id));
        }
        public IActionResult ProdutorCriar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProdutorCriar(PostProdutorDTO produtorDto)
        {
            if (!ModelState.IsValid)
            {
                return View(produtorDto);
            }
            Produtor produtor = new Produtor(produtorDto.Nome, produtorDto.FotoPerfilURL, produtorDto.Bio);
            _context.Produtores.Add(produtor);
            _context.SaveChanges();
            return RedirectToAction(nameof(ProdutorListar));
        }
        public IActionResult ProdutorAtualizar(int id)
        {
            return View();
        }
        public IActionResult ProdutorDeletar(int id)
        {
            return View();
        }
    }
}
