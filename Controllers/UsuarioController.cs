using BlogTdsTecnologia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly Persistencia _context;

        public UsuarioController(Persistencia context)
        {
            _context = context;
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Novo(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            return View();
        }

    }
}
