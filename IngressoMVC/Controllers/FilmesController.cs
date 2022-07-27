using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IngressoMVC.Models.ViewModels.RequestDTO;
using IngressoMVC.Models;

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
        [HttpPost]
        public IActionResult FilmeCriar(PostFilmeDTO filmeDto)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Nome == filmeDto.NomeCinema);
            if (cinema == null) return View();

            var produtor = _context.Produtores.FirstOrDefault(p => p.Nome == filmeDto.NomePodutor);
            if (produtor == null) return View();

             Filme filme = new Filme
                (
                    filmeDto.Titulo,
                    filmeDto.Descricao,
                    filmeDto.Preco,
                    filmeDto.ImageURL,
                    _context.Produtores.FirstOrDefault(x => x.Id == filmeDto.ProdutorId).Id
                );

            _context.Add(filme);
            _context.SaveChanges();

            //Incluir Relacionamentos
            foreach (var categoriaId in filmeDto.CategoriasId)
            {
                var novaCategoria = new FilmeCategoria(filme.Id, categoriaId);
                _context.FilmesCategorias.Add(novaCategoria);
                _context.SaveChanges();
            }

            foreach (var atorId in filmeDto.AtoresId)
            {
                var novoAtor = new AtorFilme(atorId, filme.Id);
                _context.AtoresFilmes.Add(novoAtor);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
        public IActionResult FilmeAtualizar(int id)
        {
            var result = _context.Filmes.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return View("NotFound");
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult FilmeAtualizar(int id, PostFilmeDTO filmeDto)
        {
            var result = _context.Filmes.FirstOrDefault(x => x.Id == id);

            if (!ModelState.IsValid)
            {
                return View(result);
            }
            result.AlterarDados(filmeDto.Titulo,filmeDto.Descricao,filmeDto.Preco,filmeDto.ImageURL);
            _context.Update(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(FilmeListar));
        }
        public IActionResult FilmeDeletar(int id)
        {
            var result = _context.Filmes.FirstOrDefault(x=> x.Id == id);
            return View(result);
        }
        [HttpPost,ActionName("FilmeDeletar")]
        public IActionResult FilmeDeletarConfirmar(int id)
        {
            var result = _context.Filmes.FirstOrDefault(x=> x.Id == id);
            _context.Filmes.Remove(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(FilmeListar));
        }
    }
}
