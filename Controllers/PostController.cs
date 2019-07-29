using BlogTdsTecnologia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Controllers
{
    public class PostController : Controller
    {
        private readonly Persistencia _context;

        public PostController(Persistencia context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Novo(Post post)
        {
            if (ModelState.IsValid)
            {
                post.DataCriacao = DateTime.Now;
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Novo");
            }
            return View(post);
        }


    }
}
