﻿using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
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
        [HttpPost]
        public IActionResult AtorCriar(PostAtorDTO atorDto)
        {
            if (!ModelState.IsValid)
            {
                return View(atorDto);
            }
            Ator ator = new Ator(atorDto.Nome, atorDto.FotoPerfilURL, atorDto.Bio);
            _context.Atores.Add(ator);
            _context.SaveChanges();
            return RedirectToAction(nameof(AtorListar));
        }
        public IActionResult AtorAtualizar(int id)
        {
            return View();
        }
        public IActionResult AtorDeletar(int id)
        {
            var result = _context.Atores.FirstOrDefault(a => a.Id == id);
            if (result == null)
            {
                return View();
            }
            return View(result);
        }
        [HttpDelete]
        public IActionResult AtorConfirmarDeletar(int id)
        {
            var result = _context.Atores.FirstOrDefault(a => a.Id == id);
            _context.Atores.Remove(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(AtorListar));
        }
    }
}
