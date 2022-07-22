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
        [HttpPost]
        public IActionResult CategoriaCriar(PostCategoriaDTO categoriaDto)
        {
            if (!ModelState.IsValid)
            {
                return View(categoriaDto);
            }
            Categoria categoria = new Categoria(categoriaDto.Nome);
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return RedirectToAction(nameof(CategoriaListar));
        }
        public IActionResult CategoriaAtualizar(int id)
        {
            if (id == null)
            {
                return View();
            }
            var result = _context.Categorias.FirstOrDefault(a => a.Id == id);
            if (result == null)
            {
                return View();
            }

            return View(result);
        }
         [HttpPost,ActionName("CategoriaAtualizar")]
        public IActionResult CategoriaAtualizarConfirmar(int id, PostCategoriaDTO categoriaDto)
        {
            var result = _context.Categorias.FirstOrDefault(a => a.Id == id);
            result.AtualizarDados(categoriaDto.Nome);
            _context.Categorias.Update(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(CategoriaListar));
        }
        public IActionResult CategoriaDeletar(int id)
        {
            var result = _context.Categorias.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                return View("NotFound");
            }
            return View(result);
        }
        [HttpPost, ActionName("CategoriaDeletar")]
        public IActionResult CategoriaDeletarConfirmar(int id)
        {
            var result = _context.Categorias.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                return View("NotFound");
            }
            _context.Categorias.Remove(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(CategoriaListar));
        }
    }
}
